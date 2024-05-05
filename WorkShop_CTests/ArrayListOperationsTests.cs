using Workshop_C;

namespace WorkShop_CTests;

using Xunit;
using System;
using System.Collections.Generic;

public class ArrayListOperationsTests
{
    private ArrayListOperation _arrayOps = new ArrayListOperation();


    // Pruebas para GetMaxValue
    [Fact]
    public void GetMaxValue_ValidList_ReturnsMax()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5 };

        int result = _arrayOps.GetMaxValue(numbers);

        Assert.Equal(5, result); // Valor máximo esperado
    }


    [Fact]
    public void GetMaxValue_ListWithNegativeNumbers_ReturnsMax()
    {
        var numbers = new List<int> { -5, -10, -2 };

        int result = _arrayOps.GetMaxValue(numbers);

        Assert.Equal(-2, result); // Valor máximo esperado
    }

    [Fact]
    public void GetMaxValue_ListWithSameValues_ReturnsSameValue()
    {
        var numbers = new List<int> { 2, 2, 2 };

        int result = _arrayOps.GetMaxValue(numbers);

        Assert.Equal(2, result); // Todos los valores son iguales
    }

    // Pruebas para GetMinValue
    [Fact]
    public void GetMinValue_ValidList_ReturnsMin()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5 };

        int result = _arrayOps.GetMinValue(numbers);

        Assert.Equal(1, result); // Valor mínimo esperado
    }

    [Fact]
    public void GetMinValue_ListWithNegativeNumbers_ReturnsMin()
    {
        var numbers = new List<int> { -5, -10, -2 };

        int result = _arrayOps.GetMinValue(numbers);

        Assert.Equal(-10, result); // Valor mínimo esperado
    }

    [Fact]
    public void GetMinValue_ListWithSameValues_ReturnsSameValue()
    {
        var numbers = new List<int> { 2, 2, 2 };

        int result = _arrayOps.GetMinValue(numbers);

        Assert.Equal(2, result); // Todos los valores son iguales
    }

    // Pruebas para CalculateAverage
    [Fact]
    public void CalculateAverage_ValidList_ReturnsAverage()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5 };

        double result = _arrayOps.CalculateAverage(numbers);

        Assert.Equal(3, result, 1); // Promedio esperado con precisión de un decimal
    }

    [Fact]
    public void CalculateAverage_ListWithNegativeNumbers_ReturnsAverage()
    {
        var numbers = new List<int> { -5, -10, -2 };

        double result = _arrayOps.CalculateAverage(numbers);

        Assert.Equal(-5.7, result, 1); // Promedio esperado
    }

    [Fact]
    public void CalculateAverage_ListWithMixedValues_ReturnsAverage()
    {
        var numbers = new List<int> { -5, 5, 10 };

        double result = _arrayOps.CalculateAverage(numbers);

        Assert.Equal(3.3, result, 1); // Promedio esperado
    }

    // Pruebas para FindElement
    [Fact]
    public void FindElement_ExistingElement_ReturnsIndex()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5 };

        int result = _arrayOps.FindElement(numbers, 3);

        Assert.Equal(2, result); // Índice esperado
    }

    [Fact]
    public void FindElement_NonExistingElement_ReturnsMinusOne()
    {
        var numbers = new List<int>();

        int result = _arrayOps.FindElement(numbers, 6);

        Assert.Equal(-1, result); // No debe encontrarse el elemento
    }


    // Pruebas para CountOccurrences
    [Fact]
    public void CountOccurrences_ValidList_ReturnsCount()
    {
        var numbers = new List<int> { 1, 2, 3, 2, 2 };

        int result = _arrayOps.CountOccurrences(numbers, 2);

        Assert.Equal(3, result); // El número de veces que aparece el 2
    }

    [Fact]
    public void CountOccurrences_NoOccurrences_ReturnsZero()
    {
        var numbers = new List<int> { 1, 2, 3 };

        int result = _arrayOps.CountOccurrences(numbers, 4);

        Assert.Equal(0, result); // No hay ocurrencias de 4
    }

    [Fact]
    public void CountOccurrences_EmptyList_ReturnsZero()
    {
        var numbers = new List<int> { };

        int result = _arrayOps.CountOccurrences(numbers, 1);

        Assert.Equal(0, result); // La lista está vacía
    }

    [Fact]
    public void CountOccurrences_ListWithNegativeValues_ReturnsCount()
    {
        var numbers = new List<int> { -1, -2, -2, 0, 1 };

        int result = _arrayOps.CountOccurrences(numbers, -2);

        Assert.Equal(2, result); // Dos veces el número -2
    }

    // Pruebas para ReverseArray
    [Fact]
    public void ReverseArray_ValidArray_ReturnsReversed()
    {
        var array = new int[] { 1, 2, 3, 4, 5 };

        int[] result = _arrayOps.ReverseArray(array);

        Assert.Equal(new int[] { 5, 4, 3, 2, 1 }, result); // El array invertido
    }

    [Fact]
    public void ReverseArray_EmptyArray_ReturnsEmpty()
    {
        var array = new int[] { };

        int[] result = _arrayOps.ReverseArray(array);

        Assert.Equal(new int[] { }, result); // El array vacío invertido sigue vacío
    }

    [Fact]
    public void ReverseArray_SingleElementArray_ReturnsSameArray()
    {
        var array = new int[] { 1 };

        int[] result = _arrayOps.ReverseArray(array);

        Assert.Equal(new int[] { 1 }, result); // El array con un solo elemento no cambia al invertirlo
    }

    [Fact]
    public void ReverseArray_ArrayWithNegativeValues_ReturnsReversed()
    {
        var array = new int[] { -5, -4, -3, -2, -1 };

        int[] result = _arrayOps.ReverseArray(array);

        Assert.Equal(new int[] { -1, -2, -3, -4, -5 }, result); // El array con valores negativos invertido
    }

    // Pruebas para SortArray
    [Fact]
    public void SortArray_ValidArray_ReturnsSorted()
    {
        var array = new int[] { 5, 2, 4, 1, 3 };

        int[] result = _arrayOps.SortArray(array);

        Assert.Equal(new int[] { 1, 2, 3, 4, 5 }, result); // El array ordenado
    }

    [Fact]
    public void SortArray_EmptyArray_ReturnsEmpty()
    {
        var array = new int[] { };

        int[] result = _arrayOps.SortArray(array);

        Assert.Equal(new int[] { }, result); // El array vacío sigue vacío
    }

    [Fact]
    public void SortArray_SingleElementArray_ReturnsSameArray()
    {
        var array = new int[] { 1 };

        int[] result = _arrayOps.SortArray(array);

        Assert.Equal(new int[] { 1 }, result); // El array con un solo elemento no cambia al ordenarlo
    }

    [Fact]
    public void SortArray_ArrayWithDuplicates_ReturnsSorted()
    {
        var array = new int[] { 3, 1, 2, 2, 3 };

        int[] result = _arrayOps.SortArray(array);

        Assert.Equal(new int[] { 1, 2, 2, 3, 3 }, result); // El array ordenado con duplicados
    }

    // Pruebas para GetUniqueElements
    [Fact]
    public void GetUniqueElements_ValidList_ReturnsUniqueElements()
    {
        var numbers = new List<int> { 1, 2, 3, 2, 3, 4, 5 };

        List<int> result = _arrayOps.GetUniqueElements(numbers);

        Assert.Equal(new List<int> { 1, 2, 3, 4, 5 }, result); // Elementos únicos
    }

    [Fact]
    public void GetUniqueElements_EmptyList_ReturnsEmptyList()
    {
        var numbers = new List<int> { };

        List<int> result = _arrayOps.GetUniqueElements(numbers);

        Assert.Equal(new List<int> { }, result); // Lista vacía para elementos únicos
    }

    [Fact]
    public void GetUniqueElements_ListWithDuplicates_ReturnsUniqueElements()
    {
        var numbers = new List<int> { 3, 3, 2, 2, 1 };

        List<int> result = _arrayOps.GetUniqueElements(numbers);

        Assert.Equal(new List<int> { 1, 2, 3 }, result); // Lista de elementos únicos
    }

    [Fact]
    public void GetUniqueElements_ListWithNegativeValues_ReturnsUniqueElements()
    {
        var numbers = new List<int> { -1, -2, -2, 0, 1 };

        List<int> result = _arrayOps.GetUniqueElements(numbers);

        Assert.Equal(new List<int> { -2, -1, 0, 1 }, result); // Lista con valores negativos únicos
    }

    // Pruebas para SumElements
    [Fact]
    public void SumElements_ValidList_ReturnsSum()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5 };

        int result = _arrayOps.SumElements(numbers);

        Assert.Equal(15, result); // Suma esperada
    }

    [Fact]
    public void SumElements_EmptyList_ReturnsZero()
    {
        var numbers = new List<int> { };

        int result = _arrayOps.SumElements(numbers);

        Assert.Equal(0, result); // La suma de una lista vacía es cero
    }

    [Fact]
    public void SumElements_ListWithNegativeValues_ReturnsSum()
    {
        var numbers = new List<int> { -1, -2, -3 };

        int result = _arrayOps.SumElements(numbers);

        Assert.Equal(-6, result); // Suma esperada con valores negativos
    }

    [Fact]
    public void SumElements_ListWithMixedValues_ReturnsSum()
    {
        var numbers = new List<int> { -10, -3, 5, -9, 7, 12 };
        //una lista con valores negativos y positivos que sumen 2

        int result = _arrayOps.SumElements(numbers);

        Assert.Equal(2, result); // Suma esperada
    }

    // Pruebas para MultiplyElements
    [Fact]
    public void MultiplyElements_ValidList_ReturnsProduct()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5 };

        long result = _arrayOps.MultiplyElements(numbers);

        Assert.Equal(120, result); // Producto de 1 a 5
    }

    [Fact]
    public void MultiplyElements_EmptyList_ReturnsOne()
    {
        var numbers = new List<int>();

        long result = _arrayOps.MultiplyElements(numbers);

        Assert.Equal(1, result); // Producto de una lista vacía es 1
    }

    [Fact]
    public void MultiplyElements_ListWithZero_ReturnsZero()
    {
        var numbers = new List<int> { 10, -3, 5, 9, 7, 12 };

        long result = _arrayOps.MultiplyElements(numbers);

        Assert.Equal(0, result); // Producto con cero es cero
    }

    [Fact]
    public void MultiplyElements_ListWithNegativeValues_ReturnsProduct()
    {
        var numbers = new List<int> { -3, -1, -2 };
        //una lista con valores -1 a -3

        long result = _arrayOps.MultiplyElements(numbers);

        Assert.Equal(-6, result); // Producto esperado
    }

    // Pruebas para GetSecondLargest
    [Fact]
    public void GetSecondLargest_ValidList_ReturnsSecondLargest()
    {
        var numbers = new List<int> { 1, 3, 5, 2, 4 };

        int result = _arrayOps.GetSecondLargest(numbers);

        Assert.Equal(4, result); // El segundo más grande
    }

    [Fact]
    public void GetSecondLargest_ListWithDuplicates_ReturnsSecondLargest()
    {
        var numbers = new List<int> { 1, 3, 3, 5, 5 };

        int result = _arrayOps.GetSecondLargest(numbers);

        Assert.Equal(3, result); // El segundo más grande, considerando duplicados
    }

    [Fact]
    public void GetSecondLargest_ListWithNegativeValues_ReturnsSecondLargest()
    {
        var numbers = new List<int> { -1, -3, -2, -5 };

        int result = _arrayOps.GetSecondLargest(numbers);

        Assert.Equal(-2, result); // Segundo más grande entre valores negativos
    }

    [Fact]
    public void GetSecondLargest_ValidList_ReturnsSecondLargestWithRepeatedValues()
    {
        var numbers = new List<int> { 7, 5, 7, 9 };

        int result = _arrayOps.GetSecondLargest(numbers);

        Assert.Equal(7, result); // Segundo más grande con valores repetidos
    }

    // Pruebas para IsArraySorted
    [Fact]
    public void IsArraySorted_ValidSortedArray_ReturnsTrue()
    {
        var array = new int[] { 1, 2, 3, 4, 5 };

        bool result = _arrayOps.IsArraySorted(array);

        Assert.True(result); // El array está ordenado
    }

    [Fact]
    public void IsArraySorted_UnsortedArray_ReturnsFalse()
    {
        var array = new int[] { 5, 3, 1, 4, 2 };

        bool result = _arrayOps.IsArraySorted(array);

        Assert.False(result); // El array no está ordenado
    }

    [Fact]
    public void IsArraySorted_EmptyArray_ReturnsTrue()
    {
        var array = new int[] { };

        bool result = _arrayOps.IsArraySorted(array);

        Assert.True(result); // Un array vacío se considera ordenado
    }

    [Fact]
    public void IsArraySorted_SingleElementArray_ReturnsTrue()
    {
        var array = new int[] { 1 };

        bool result = _arrayOps.IsArraySorted(array);

        Assert.True(result); // Un array con un solo elemento está ordenado
    }

    // Pruebas para RemoveDuplicates
    [Fact]
    public void RemoveDuplicates_ValidList_ReturnsUniqueElements()
    {
        var numbers = new List<int> { 1, 2, 2, 3, 3, 4 };

        var result = _arrayOps.RemoveDuplicates(numbers);

        Assert.Equal(new List<int> { 1, 2, 3, 4 }, result); // Elementos únicos
    }

    [Fact]
    public void RemoveDuplicates_ListWithNoDuplicates_ReturnsSameList()
    {
        var numbers = new List<int> { 1, 2, 3 };

        var result = _arrayOps.RemoveDuplicates(numbers);

        Assert.Equal(numbers, result); // Lista sin duplicados permanece igual
    }

    [Fact]
    public void RemoveDuplicates_EmptyList_ReturnsEmptyList()
    {
        var numbers = new List<int> { };

        var result = _arrayOps.RemoveDuplicates(numbers);

        Assert.Equal(new List<int> { }, result); // Lista vacía permanece vacía
    }

    [Fact]
    public void RemoveDuplicates_ListWithNegativeValues_ReturnsUniqueElements()
    {
        var numbers = new List<int> { -1, -1, -2, 0, 1 };

        var result = _arrayOps.RemoveDuplicates(numbers);

        Assert.Equal(new List<int> { -1, -2, 0, 1 }, result); // Lista con valores únicos
    }

    // Pruebas para RotateArray
    [Fact]
    public void RotateArray_ValidArray_ReturnsRotatedArray()
    {
        var array = new int[] { 1, 2, 3, 4, 5 };

        int[] result = _arrayOps.RotateArray(array, 2);

        Assert.Equal(new int[] { 3, 4, 5, 1, 2 }, result); // Array rotado
    }

    [Fact]
    public void RotateArray_EmptyArray_ReturnsEmptyArray()
    {
        var array = new int[] { };

        int[] result = _arrayOps.RotateArray(array, 2);

        Assert.Equal(new int[] { }, result); // Rotar un array vacío sigue vacío
    }

    [Fact]
    public void RotateArray_RotateByZeroPositions_ReturnsSameArray()
    {
        var array = new[] { 1, 2, 3, 4, 5 };
        //una lista con valores entre 1 y 5

        int[] result = _arrayOps.RotateArray(array, 0);

        Assert.Equal(array, result); // Array con rotación cero sigue igual
    }

    [Fact]
    public void RotateArray_RotateByMoreThanArrayLength_ReturnsRotatedArray()
    {
        var array = new[] { 1, 2, 3, 4, 5 };

        int[] result = _arrayOps.RotateArray(array, 7);

        Assert.Equal(new int[] { 3, 4, 5, 1, 2 }, result); // Rotación por más posiciones que longitud del array
    }

    // Pruebas para FindMedian
    [Fact]
    public void FindMedian_ValidList_ReturnsMedian()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5 };
        //una lista con valores del 1 al 5

        double result = _arrayOps.FindMedian(numbers);

        Assert.Equal(3, result); // Mediana esperada
    }

    [Fact]
    public void FindMedian_ListWithEvenNumberOfElements_ReturnsMedian()
    {
        var numbers = new List<int> { 1, 2, 3, 4 };

        double result = _arrayOps.FindMedian(numbers);

        Assert.Equal(2.5, result, 1); // Mediana esperada con precisión de un decimal
    }

    [Fact]
    public void FindMedian_SingleElementList_ReturnsElement()
    {
        var numbers = new List<int> { 1 };

        double result = _arrayOps.FindMedian(numbers);

        Assert.Equal(1, result); // Mediana de una lista con un solo elemento
    }

    [Fact]
    public void FindMedian_ListWithNegativeValues_ReturnsMedian()
    {
        var numbers = new List<int>{-1,-2,-3,-4,-5};

        double result = _arrayOps.FindMedian(numbers);

        Assert.Equal(-1.5, result, 1); // Mediana esperada
    }
    

    // Pruebas para CalculateStandardDeviation
    [Fact]
    public void CalculateStandardDeviation_ValidList_ReturnsStandardDeviation()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5 };

        double result = _arrayOps.CalculateStandardDeviation(numbers);

        Assert.Equal(1.414, result, 3); // Desviación estándar esperada (con precisión de 3 decimales)
    }

    [Fact]
    public void CalculateStandardDeviation_EmptyList_ReturnsZero()
    {
        var numbers = new List<int> { };

        double result = _arrayOps.CalculateStandardDeviation(numbers);

        Assert.Equal(0, result); // Desviación estándar de lista vacía
    }

    [Fact]
    public void CalculateStandardDeviation_ListWithSameValues_ReturnsZero()
    {
        var numbers = new List<int> { 2, 2, 2 };

        double result = _arrayOps.CalculateStandardDeviation(numbers);

        Assert.Equal(0, result); // Desviación estándar de valores iguales
    }

    [Fact]
    public void CalculateStandardDeviation_ListWithNegativeValues_ReturnsStandardDeviation()
    {
        var numbers = new List<int> { -2, -3, -5, -4 };
            //una lista con valores entre -1 y -5

        double result = _arrayOps.CalculateStandardDeviation(numbers);

        Assert.Equal(1.414, result, 3); // Desviación estándar esperada
    }

    // Pruebas para CheckForValue
    [Fact]
    public void CheckForValue_ValidList_ReturnsTrue()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5 };

        bool result = _arrayOps.CheckForValue(numbers, 3);

        Assert.True(result); // El valor 3 está en la lista
    }

    [Fact]
    public void CheckForValue_ValidList_ReturnsFalse()
    {
        var numbers = new List<int> { 0,1,3,4,2,5}; 
            //una lista con valores entre 1 y 5

        bool result = _arrayOps.CheckForValue(numbers, 6);

        Assert.False(result); // El valor 6 no está en la lista
    }

    [Fact]
    public void CheckForValue_ListWithNegativeValues_ReturnsTrue()
    {
        var numbers =  new List<int> { 0,1,3,4,2,5,-3,-7,60,-42,7};
            //una lista con valores negativos

        bool result = _arrayOps.CheckForValue(numbers, -3);

        Assert.True(result); // El valor -3 está en la lista
    }

    [Fact]
    public void CheckForValue_ListWithEmptyList_ReturnsFalse()
    {
        var numbers = new List<int>();

        bool result = _arrayOps.CheckForValue(numbers, 1);

        Assert.False(result); // No hay valores en una lista vacía
    }

    // Pruebas para SplitArray
    [Fact]
    public void SplitArray_ValidArray_ReturnsTwoSubarrays()
    {
        var array = new []{ 1,3,4,2,5}; 

        var result = _arrayOps.SplitArray(array, 3);

        Assert.Equal(new int[] { 1, 2, 3 }, result.Item1); // Primer subarray
        Assert.Equal(new int[] { 4, 5 }, result.Item2); // Segundo subarray
    }

    [Fact]
    public void SplitArray_SplitAtBeginning_ReturnsTwoSubarrays()
    {
        var array = new []{ 1,3,4,2,5}; 

        var result = _arrayOps.SplitArray(array, 0);

        Assert.Equal(new int[] { }, result.Item1); // Subarray vacío
        Assert.Equal(array, result.Item2); // El segundo subarray es el array completo
    }

    [Fact]
    public void SplitArray_SplitAtEnd_ReturnsTwoSubarrays()
    {
        var array = new []{ 1,3,4,2,5}; 

        var result = _arrayOps.SplitArray(array, 5);

        Assert.Equal(array, result.Item1); // El primer subarray es el array completo
        Assert.Equal(new int[] { }, result.Item2); // El segundo subarray es vacío
    }

    [Fact]
    public void SplitArray_InvalidIndex_ReturnsOriginalArray()
    {
        var array = new []{ 1,3,4,2,5}; 
        var result = _arrayOps.SplitArray(array, 6);

        Assert.Null(result); // Un índice fuera de rango no debería generar subarrays válidos
    }

    // Pruebas para FindLongestSubarray
    [Fact]
    public void FindLongestSubarray_ValidArray_ReturnsLongestSubarray()
    {
        var array = new []{ 1,3,4,2,5,3,2,0,7,-3}; 

        int[] result = _arrayOps.FindLongestSubarray(array);

        Assert.Equal(new int[] { 3, 3 }, result); // Subarray más largo
    }

    [Fact]
    public void FindLongestSubarray_ArrayWithUniqueValues_ReturnsLongestSubarray()
    {
        var array = new []{ 1,3,4,2,5}; 

        int[] result = _arrayOps.FindLongestSubarray(array);

        Assert.Equal(new int[] { 1, 2, 3, 4, 5 }, result); // No hay duplicados, pero el subarray más largo es el array completo
    }

    [Fact]
    public void FindLongestSubarray_EmptyArray_ReturnsNull()
    {
        var array = new int[]{};

        int[] result = _arrayOps.FindLongestSubarray(array);

        Assert.Null(result); // Array vacío no debería devolver subarrays
    }

    [Fact]
    public void FindLongestSubarray_ArrayWithNegativeValues_ReturnsLongestSubarray()
    {
        var array = new[] { -1, -3, -4, -5, -2 ,-1};

        int[] result = _arrayOps.FindLongestSubarray(array);

        Assert.Equal(new int[] { -1, -1 }, result); // Subarray más largo entre valores negativos
    }

    // Pruebas para FindLongestConsecutiveSubsequence
    [Fact]
    public void FindLongestConsecutiveSubsequence_ValidList_ReturnsLongestSequence()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5 };

        var result = _arrayOps.FindLongestConsecutiveSubsequence(numbers);

        Assert.Equal(new List<int> { 1, 2, 3, 4, 5 }, result); // Secuencia consecutiva esperada
    }

    [Fact]
    public void FindLongestConsecutiveSubsequence_ListWithGaps_ReturnsLongestSequence()
    {
        var numbers = new List<int> { 1, 3, 4, 7 };
            //una lista con valores 1, 3, 4, 7

        var result = _arrayOps.FindLongestConsecutiveSubsequence(numbers);

        Assert.Equal(new List<int> { 3, 4 }, result); // La secuencia más larga con brechas
    }

    [Fact]
    public void FindLongestConsecutiveSubsequence_EmptyList_ReturnsEmptyList()
    {
        var numbers = new List<int>();

        var result = _arrayOps.FindLongestConsecutiveSubsequence(numbers);

        Assert.Equal(new List<int> { }, result); // Una lista vacía
    }

    [Fact]
    public void FindLongestConsecutiveSubsequence_ListWithNegativeValues_ReturnsLongestSequence()
    {
        var numbers = new List<int> { -3, -2, -1 ,-7,-12};

        var result = _arrayOps.FindLongestConsecutiveSubsequence(numbers);

        Assert.Equal(new List<int> { -3, -2, -1 }, result); // Secuencia más larga entre valores negativos
    }
}

    
