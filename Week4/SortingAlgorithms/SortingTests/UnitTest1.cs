using SortingAlgorithms;
namespace SortingTests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void GivenAnUnsortedArray_BubbleSort_Element1IsLessThanElement2()
    {
        int[] array = { 8, 2, 5, 1, 6 };
        int[] array2 = { 2, 8, 5, 1, 6 };

        int[] sortedArray = Program.BubbleSort(array);  
        int[] sortedArray2 = Program.BubbleSort(array2);

        Assert.That(sortedArray[0], Is.LessThanOrEqualTo(sortedArray[1]));
        Assert.That(sortedArray2[0], Is.LessThanOrEqualTo(sortedArray2[1]));
    }

    [Test]
    public void GivenAnUnsortedArray_BubbleSort_Element2IsLessThanElement3()
    {
        int[] array = { 8, 2, 5, 1, 6 };
        int[] array2 = { 8, 6, 5, 2, 1};

        int[] sortedArray = Program.BubbleSort(array);
        int[] sortedArray2 = Program.BubbleSort(array2);

        Assert.That(sortedArray[1], Is.LessThanOrEqualTo(sortedArray[2]));
        Assert.That(sortedArray2[1], Is.LessThanOrEqualTo(sortedArray2[2]));
    }

    [Test]
    public void GivenAnUnsortedArray_BubbleSort_ReturnsOrderedList()
    {
        int[] array = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
        int[] targetArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        int[] sortedArray = Program.BubbleSort(array);

        Assert.That(sortedArray, Is.EqualTo(targetArray));
    }
}