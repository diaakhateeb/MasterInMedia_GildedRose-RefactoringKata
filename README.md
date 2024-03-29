# Gilded Rose Refactoring Kata [![Build status](https://ci.appveyor.com/api/projects/status/96m4ue9c2agep5y7?svg=true)](https://ci.appveyor.com/project/diaakhateeb/masterinmedia-gildedrose-refactoringkata)

We are a small inn with a prime location in a prominent city ran by a friendly innkeeper named Allison. We also buy and sell only the finest goods. Unfortunately, our goods are constantly degrading in quality as they approach their sell by date. We have a system in place that updates our inventory for us. It was developed by a no-nonsense type named Leeroy, who has moved on to new adventures. Your task is to add the new feature to our system so that we can begin selling a new category of items. First an introduction to our system:

-   All items have a SellIn value which denotes the number of days we have to sell the item
-   All items have a Quality value which denotes how valuable the item is
-   At the end of each day our system lowers both values for every item

Pretty simple, right? Well this is where it gets interesting:

-   Once the sell by date has passed, Quality degrades twice as fast
-   The Quality of an item is never negative
-   "Aged Brie" actually increases in Quality the older it gets
-   The Quality of an item is never more than 50
-   "Sulfuras", being a legendary item, never has to be sold or decreases in Quality
-   "Backstage passes", like aged brie, increases in Quality as it's SellIn value approaches; Quality increases by 2 when there are 10 days or less and by 3 when there are 5 days or less but Quality drops to 0 after the concert

We have recently signed a supplier of conjured items. This requires an update to our system:

-   "Conjured" items degrade in Quality twice as fast as normal items

Feel free to make any changes to the UpdateQuality method and add any new code as long as everything still works correctly. However, do not alter the Item class or Items property as those belong to the goblin in the corner who will insta-rage and one-shot you as he doesn't believe in shared code ownership (you can make the UpdateQuality method and Items property static if you like, we'll cover for you).

Just for clarification, an item can never have its Quality increase above 50, however "Sulfuras" is a legendary item and as such its Quality is 80 and it never alters.

## Solution Approaches:
We are not allowed to change Item class and therefore it is a concrete component to us.

### 1. [Using Generics](https://github.com/diaakhateeb/MasterInMedia_GildedRose-RefactoringKata/tree/master/MasterInMedia_GildedRose-RefactoringKata):

 **- Pros:**
1. Flexibility of type checking (specifically Item base class or any of its children).
2. Factory GetInstance() method check is done using item name which is a string value (performance wise).
3. No one to one relationship with Item class (no dependency).

**- Cons:**
1. Instantiating the appropriate item instance is done based on item name which is a string value. This might cause character error checking. In addition, it is not the best practice of implementing or using Factory pattern.
2. Factory GetInstance() method needs to cast the Generic type to the appropriate item type (performance factor).


### 2. [Using Created Item Type](https://github.com/diaakhateeb/MasterInMedia_GildedRose-RefactoringKata/tree/master/MasterInMedia_GildedRose-RefactoringKataV2):

 **- Pros:**
1. Each item (including new one) is having its own class component that inherits from Item base class. This provides ability to let each item exposes its own functions additional to having Item base class members (Polymorphism).
2. Factory GetInstance() method uses object not string value for deciding the needed item type.
3. Factory GetInstance() method does not need to cast the passed item object. It only checks its type.

**- Cons:**
1. One to one relationship between the created item class and the Item base class (dependency).
2. Memory time and space are used in terms of performance for each item class Instantiation.

### Unit Testing:
In addition to the [ApprovalTest](https://github.com/diaakhateeb/MasterInMedia_GildedRose-RefactoringKata/blob/master/MasterInMedia_GildedRose-RefactoringKataTest/ApprovalTest.cs) shipped with the original project, each item type has its own unit tests as follows:

 - **[AgedBrieTest](https://github.com/diaakhateeb/MasterInMedia_GildedRose-RefactoringKata/blob/master/MasterInMedia_GildedRose-RefactoringKataTest/AgedBrieTest.cs):** It has QualityIncreasesByOne_SellInIsPositive(), QualityIncreasesByTwo_SellInIsZeroOrNegative() and QualityCannotBeMoreThan50() unit tests.
- **[BackStagePassesTest](https://github.com/diaakhateeb/MasterInMedia_GildedRose-RefactoringKata/blob/master/MasterInMedia_GildedRose-RefactoringKataTest/BackStagePassesTest.cs):** It has QualityIncreaseByOne_SellInGreaterThan10(), QualityIncreaseByTwo_SellInBetween10And6(), QualityIncreaseByTwo_SellInBetween5And0(), QualityShouldBeZero_WhenSellInNegative() and QualityCannotBeMoreThan50() unit tests.
- **[ConjuredTest](https://github.com/diaakhateeb/MasterInMedia_GildedRose-RefactoringKata/blob/master/MasterInMedia_GildedRose-RefactoringKataTest/ConjuredTest.cs):** It has DegradeQualityByOne_SellInIsPositive(), DegradeSellInByOne_SellInIsPositive(), QualityDegradesTwiceAsFast_SellInIsNegative() and QualityIsNeverNegative() unit tests.
- **[LegendaryTest](https://github.com/diaakhateeb/MasterInMedia_GildedRose-RefactoringKata/blob/master/MasterInMedia_GildedRose-RefactoringKataTest/LegendaryTest.cs):** It has QualityIsAlways80() and SellInNotDecreased() unit tests.
 - **[StandardTest](https://github.com/diaakhateeb/MasterInMedia_GildedRose-RefactoringKata/blob/master/MasterInMedia_GildedRose-RefactoringKataTest/StandardTest.cs):** It has DegradeQualityByOne_SellInIsPositive(), DegradeSellInByOne_SellInIsPositive(), QualityDegradesTwiceAsFast_SellInIsNegative() and QualityIsNeverNegative() unit tests.

The solution errors and exceptions are logged using [NLog](https://nlog-project.org).

## Running the Solution
Clone the solution and through the CLI execute **dotnet run -p** "project folder path" command.
