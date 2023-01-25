using MergeSort;
namespace MergeSortTests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }
    [Test]
    public void GivenUnsortedArray_MergeSort_ReturnsSortedArray()
    {
        int[] array1 = { 0, 4, 2, 6, 1, 3, 6, 7, 1, 10, 8 };
        int[] array2 = { 4, 3, 2, 1 };

        int[] expectedArray1 = { 0, 1, 1, 2, 3, 4, 6, 6, 7, 8, 10 };
        int[] expectedArray2 = { 1, 2, 3, 4 };

        int[] resultArray1 = Program.MergeSort(array1);
        int[] resultArray2 = Program.MergeSort(array2);

        Assert.That(resultArray1, Is.EqualTo(expectedArray1));
        Assert.That(resultArray2, Is.EqualTo(expectedArray2));
    }

    [Test]

    public void GivenTwoSortedArrays_Merge_ReturnsOneSortedArray()
    {
        int[] array1 = { 2, 5, 7 };
        int[] array2 = { 1, 2, 6 };

        int[] expectedArray = { 1, 2, 2, 5, 6, 7 };

        int[] resultArray = Program.Merge(array1, array2);

        Assert.That(resultArray, Is.EqualTo(expectedArray));
    }

    [Test]

    public void GivenAnArray_Split_SplitsIntoTwoArrays()
    {
        int[] array1 = { 1, 2, 3, 4 };
        int[] array2 = { 2, 3, 4 };

        int[] expectedArray1_1 = { 1, 2 };
        int[] expectedArray1_2 = { 3, 4 };

        int[] expectedArray2_1 = { 2 };
        int[] expectedArray2_2 = { 3,4 };

        Program.Split(array1, out int[] resultArray1_1, out int[] resultArray1_2);
        Program.Split(array2, out int[] resultArray2_1, out int[] resultArray2_2);

        Assert.That(resultArray1_1, Is.EqualTo(expectedArray1_1));
        Assert.That(resultArray1_2, Is.EqualTo(expectedArray1_2));
        Assert.That(resultArray2_1, Is.EqualTo(expectedArray2_1));
        Assert.That(resultArray2_2, Is.EqualTo(expectedArray2_2));
    }
}