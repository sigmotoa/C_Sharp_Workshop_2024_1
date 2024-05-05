using Workshop_C;

namespace WorkShop_CTests;

public class GeometricOperationsTest
{
    private GeometricOperation _geoOps = new GeometricOperation();

    // 1. Pruebas para el área del círculo
    [Fact]
    public void CalculateCircleArea_CorrectResult()
    {
        double radius = 5;

        double result = _geoOps.CalculateCircleArea(radius);

        // Comprobación con resultado esperado basado en conocimientos previos
        Assert.Equal(78.54, result, 2);
    }

    [Fact]
    public void CalculateCircleArea_ZeroRadius_ReturnsZero()
    {
        double result = _geoOps.CalculateCircleArea(0);

        Assert.Equal(0, result);
    }

    [Fact]
    public void CalculateCircleArea_NegativeRadius_ReturnsInvalid()
    {
        double radius = -5;

        double result = _geoOps.CalculateCircleArea(radius);

        Assert.NotEqual(78.54, result); // Un valor incorrecto
    }

    // 2. Pruebas para el perímetro del círculo
    [Fact]
    public void CalculateCircleCircumference_CorrectResult()
    {
        double radius = 5;

        double result = _geoOps.CalculateCircleCircumference(radius);

        Assert.Equal(31.42, result, 2); // Resultado esperado
    }

    [Fact]
    public void CalculateCircleCircumference_ZeroRadius_ReturnsZero()
    {
        double result = _geoOps.CalculateCircleCircumference(0);

        Assert.Equal(0, result);
    }

    [Fact]
    public void CalculateCircleCircumference_IncorrectResult()
    {
        double radius = 5;

        double result = _geoOps.CalculateCircleCircumference(radius);

        Assert.NotEqual(35.0, result); // Valor incorrecto
    }

    // 3. Pruebas para el área del rectángulo
    [Fact]
    public void CalculateRectangleArea_CorrectResult()
    {
        double width = 5;
        double height = 10;

        double result = _geoOps.CalculateRectangleArea(width, height);

        Assert.Equal(50, result); // Valor esperado basado en conocimientos
    }

    [Fact]
    public void CalculateRectangleArea_ZeroWidth_ReturnsZero()
    {
        double width = 0;
        double height = 10;

        double result = _geoOps.CalculateRectangleArea(width, height);

        Assert.Equal(0, result);
    }

    [Fact]
    public void CalculateRectangleArea_IncorrectResult()
    {
        double width = 5;
        double height = 10;

        double result = _geoOps.CalculateRectangleArea(width, height);

        Assert.NotEqual(55, result); // Valor incorrecto
    }

    // 4. Pruebas para el perímetro del rectángulo
    [Fact]
    public void CalculateRectanglePerimeter_CorrectResult()
    {
        double width = 5;
        double height = 10;

        double result = _geoOps.CalculateRectanglePerimeter(width, height);

        Assert.Equal(30, result); // Valor esperado
    }

    [Fact]
    public void CalculateRectanglePerimeter_ZeroWidth_Returns20()
    {
        double height = 10;

        double result = _geoOps.CalculateRectanglePerimeter(0, height);

        Assert.Equal(20, result); // 2 * altura
    }

    [Fact]
    public void CalculateRectanglePerimeter_IncorrectResult()
    {
        double width = 5;
        double height = 10;

        double result = _geoOps.CalculateRectanglePerimeter(width, height);

        Assert.NotEqual(35, result); // Valor incorrecto
    }

    // 5. Pruebas para el área del triángulo
    [Fact]
    public void CalculateTriangleArea_CorrectResult()
    {
        double baseLength = 10;
        double height = 5;

        double result = _geoOps.CalculateTriangleArea(baseLength, height);

        Assert.Equal(25, result); // Área esperada
    }

    [Fact]
    public void CalculateTriangleArea_ZeroBase_ReturnsZero()
    {
        double height = 10;

        double result = _geoOps.CalculateTriangleArea(0, height);

        Assert.Equal(0, result); // Cualquier dimensión cero debe resultar en cero
    }

    [Fact]
    public void CalculateTriangleArea_IncorrectResult()
    {
        double baseLength = 10;
        double height = 5;

        double result = _geoOps.CalculateTriangleArea(baseLength, height);

        Assert.NotEqual(30, result); // Valor incorrecto
    }

    // 6. Pruebas para el perímetro del triángulo
    [Fact]
    public void CalculateTrianglePerimeter_CorrectResult()
    {
        double side1 = 3;
        double side2 = 4;
        double side3 = 5;

        double result = _geoOps.CalculateTrianglePerimeter(side1, side2, side3);

        Assert.Equal(12, result); // Perímetro esperado
    }

    [Fact]
    public void CalculateTrianglePerimeter_ZeroSide_ReturnsIncorrect()
    {
        double result = _geoOps.CalculateTrianglePerimeter(0, 4, 5);

        Assert.NotEqual(12, result); // Con un lado cero, no debería ser 12
    }

    [Fact]
    public void CalculateTrianglePerimeter_IncorrectResult()
    {
        double side1 = 3;
        double side2 = 4;
        double side3 = 5;

        double result = _geoOps.CalculateTrianglePerimeter(side1, side2, side3);

        Assert.NotEqual(10, result); // Perímetro incorrecto
    }

    // 7. Pruebas para el área del cuadrado
    [Fact]
    public void CalculateSquareArea_CorrectResult()
    {
        double side = 5;

        double result = _geoOps.CalculateSquareArea(side);

        Assert.Equal(25, result); // Área esperada
    }

    [Fact]
    public void CalculateSquareArea_ZeroSide_ReturnsZero()
    {
        double result = _geoOps.CalculateSquareArea(0);

        Assert.Equal(0, result);
    }

    [Fact]
    public void CalculateSquareArea_IncorrectResult()
    {
        double side = 5;

        double result = _geoOps.CalculateSquareArea(side);

        Assert.NotEqual(30, result); // Área incorrecta
    }

    // 8. Pruebas para el perímetro del cuadrado
    [Fact]
    public void CalculateSquarePerimeter_CorrectResult()
    {
        double side = 5;

        double result = _geoOps.CalculateSquarePerimeter(side);

        Assert.Equal(20, result); // Perímetro esperado
    }

    [Fact]
    public void CalculateSquarePerimeter_ZeroSide_ReturnsZero()
    {
        double result = _geoOps.CalculateSquarePerimeter(0);

        Assert.Equal(0, result); // Perímetro debería ser cero
    }

    [Fact]
    public void CalculateSquarePerimeter_IncorrectResult()
    {
        double side = 5;

        double result = _geoOps.CalculateSquarePerimeter(side);

        Assert.NotEqual(25, result); // Perímetro incorrecto
    }

    // 9. Pruebas para la hipotenusa de un triángulo rectángulo

    [Fact]
    public void CalculateHypotenuse_ZeroSide_ReturnsIncorrect()
    {
        double result = _geoOps.CalculateHypotenuse(0, 4);

        Assert.NotEqual(5, result); // No debería ser 5 con un lado cero
    }

    [Fact]
    public void CalculateHypotenuse_IncorrectResult()
    {
        double sideA = 3;
        double sideB = 4;

        double result = _geoOps.CalculateHypotenuse(sideA, sideB);

        Assert.NotEqual(6, result); // Hipotenusa incorrecta
    }

    // 10. Pruebas para el área del trapecio
    [Fact]
    public void CalculateTrapezoidArea_CorrectResult()
    {
        double base1 = 5;
        double base2 = 10;
        double height = 7;

        double result = _geoOps.CalculateTrapezoidArea(base1, base2, height);

        Assert.Equal(52.5, result); // Área esperada
    }

    [Fact]
    public void CalculateTrapezoidArea_ZeroHeight_ReturnsZero()
    {
        double base1 = 5;
        double base2 = 10;

        double result = _geoOps.CalculateTrapezoidArea(base1, base2, 0);

        Assert.Equal(0, result); // Sin altura, el área es cero
    }

    [Fact]
    public void CalculateTrapezoidArea_IncorrectResult()
    {
        double base1 = 5;
        double base2 = 10;
        double height = 7;

        double result = _geoOps.CalculateTrapezoidArea(base1, base2, height);

        Assert.NotEqual(55, result); // Área incorrecta
    }


    // 11. Pruebas para el volumen del cilindro
    [Fact]
    public void CalculateCylinderVolume_CorrectResult()
    {
        double radius = 5;
        double height = 10;

        double result = _geoOps.CalculateCylinderVolume(radius, height);

        Assert.Equal(785.4, result, 1); // Valor esperado (aproximado)
    }

    [Fact]
    public void CalculateCylinderVolume_ZeroHeight_ReturnsZero()
    {
        double radius = 5;

        double result = _geoOps.CalculateCylinderVolume(radius, 0);

        Assert.Equal(0, result);
    }

    [Fact]
    public void CalculateCylinderVolume_IncorrectResult()
    {
        double radius = 5;
        double height = 10;

        double result = _geoOps.CalculateCylinderVolume(radius, height);

        Assert.NotEqual(800, result); // Volumen incorrecto
    }

    // 12. Pruebas para el volumen del cubo
    [Fact]
    public void CalculateCubeVolume_CorrectResult()
    {
        double side = 5;

        double result = _geoOps.CalculateCubeVolume(side);

        Assert.Equal(125, result); // Volumen esperado
    }

    [Fact]
    public void CalculateCubeVolume_ZeroSide_ReturnsZero()
    {
        double result = _geoOps.CalculateCubeVolume(0);

        Assert.Equal(0, result); // Volumen debe ser cero
    }

    [Fact]
    public void CalculateCubeVolume_IncorrectResult()
    {
        double side = 5;

        double result = _geoOps.CalculateCubeVolume(side);

        Assert.NotEqual(130, result); // Volumen incorrecto
    }

    // 13. Pruebas para el volumen de la esfera
    [Fact]
    public void CalculateSphereVolume_CorrectResult()
    {
        double radius = 5;

        double result = _geoOps.CalculateSphereVolume(radius);

        Assert.Equal(523.6, result, 1); // Valor esperado (aproximado)
    }

    [Fact]
    public void CalculateSphereVolume_ZeroRadius_ReturnsZero()
    {
        double result = _geoOps.CalculateSphereVolume(0);

        Assert.Equal(0, result); // Volumen debe ser cero
    }

    [Fact]
    public void CalculateSphereVolume_IncorrectResult()
    {
        double radius = 5;

        double result = _geoOps.CalculateSphereVolume(radius);

        Assert.NotEqual(530, result); // Volumen incorrecto
    }

    // 14. Pruebas para el área superficial del cilindro
    [Fact]
    public void CalculateCylinderSurfaceArea_CorrectResult()
    {
        double radius = 5;
        double height = 10;

        double result = _geoOps.CalculateCylinderSurfaceArea(radius, height);

        Assert.Equal(471.2, result, 1); // Valor esperado (aproximado)
    }

    [Fact]
    public void CalculateCylinderSurfaceArea_ZeroRadius_ReturnsZero()
    {
        double height = 10;

        double result = _geoOps.CalculateCylinderSurfaceArea(0, height);

        Assert.Equal(0, result); // Área superficial debe ser cero
    }

    [Fact]
    public void CalculateCylinderSurfaceArea_IncorrectResult()
    {
        double radius = 5;
        double height = 10;

        double result = _geoOps.CalculateCylinderSurfaceArea(radius, height);

        Assert.NotEqual(480, result); // Área incorrecta
    }

    // 15. Pruebas para el área superficial del cubo
    [Fact]
    public void CalculateCubeSurfaceArea_CorrectResult()
    {
        double side = 5;

        double result = _geoOps.CalculateCubeSurfaceArea(side);

        Assert.Equal(150, result); // Área superficial esperada
    }

    [Fact]
    public void CalculateCubeSurfaceArea_ZeroSide_ReturnsZero()
    {
        double result = _geoOps.CalculateCubeSurfaceArea(0);

        Assert.Equal(0, result); // Área superficial debería ser cero
    }

    [Fact]
    public void CalculateCubeSurfaceArea_IncorrectResult()
    {
        double side = 5;

        double result = _geoOps.CalculateCubeSurfaceArea(side);

        Assert.NotEqual(160, result); // Área incorrecta
    }

    // 16. Pruebas para el área superficial de la esfera
    [Fact]
    public void CalculateSphereSurfaceArea_CorrectResult()
    {
        double radius = 5;

        double result = _geoOps.CalculateSphereSurfaceArea(radius);

        Assert.Equal(314.2, result, 1); // Valor esperado (aproximado)
    }

    [Fact]
    public void CalculateSphereSurfaceArea_ZeroRadius_ReturnsZero()
    {
        double result = _geoOps.CalculateSphereSurfaceArea(0);

        Assert.Equal(0, result); // Área superficial debería ser cero
    }

    [Fact]
    public void CalculateSphereSurfaceArea_IncorrectResult()
    {
        double radius = 5;

        double result = _geoOps.CalculateSphereSurfaceArea(radius);

        Assert.NotEqual(320, result); // Área incorrecta
    }

    // 17. Pruebas para el volumen del cono
    [Fact]
    public void CalculateConeVolume_CorrectResult()
    {
        double radius = 5;
        double height = 10;

        double result = _geoOps.CalculateConeVolume(radius, height);

        Assert.Equal(261.8, result, 1); // Valor esperado (aproximado)
    }

    [Fact]
    public void CalculateConeVolume_ZeroHeight_ReturnsZero()
    {
        double radius = 5;

        double result = _geoOps.CalculateConeVolume(radius, 0);

        Assert.Equal(0, result); // Volumen debe ser cero
    }

    [Fact]
    public void CalculateConeVolume_IncorrectResult()
    {
        double radius = 5;
        double height = 10;

        double result = _geoOps.CalculateConeVolume(radius, height);

        Assert.NotEqual(270, result); // Volumen incorrecto
    }

    // 18. Pruebas para el volumen de la pirámide
    [Fact]
    public void CalculatePyramidVolume_CorrectResult()
    {
        double baseArea = 50;
        double height = 10;

        double result = _geoOps.CalculatePyramidVolume(baseArea, height);

        Assert.Equal(166.7, result, 1); // Valor esperado (aproximado)
    }

    [Fact]
    public void CalculatePyramidVolume_ZeroHeight_ReturnsZero()
    {
        double baseArea = 50;

        double result = _geoOps.CalculatePyramidVolume(baseArea, 0);

        Assert.Equal(0, result); // Volumen debe ser cero
    }

    [Fact]
    public void CalculatePyramidVolume_IncorrectResult()
    {
        double baseArea = 50;
        double height = 10;

        double result = _geoOps.CalculatePyramidVolume(baseArea, height);

        Assert.NotEqual(170, result); // Volumen incorrecto
    }

    // 19. Pruebas para el área del polígono regular
    [Fact]
    public void CalculateRegularPolygonArea_CorrectResult()
    {
        int numSides = 5;
        double sideLength = 10;

        double result = _geoOps.CalculateRegularPolygonArea(numSides, sideLength);

        Assert.Equal(172.0, result, 1); // Valor esperado (aproximado)
    }

    [Fact]
    public void CalculateRegularPolygonArea_ZeroSides_ReturnsZero()
    {
        int numSides = 0;
        double sideLength = 10;

        double result = _geoOps.CalculateRegularPolygonArea(numSides, sideLength);

        Assert.Equal(0, result); // Área debería ser cero
    }

    [Fact]
    public void CalculateRegularPolygonArea_IncorrectResult()
    {
        int numSides = 5;
        double sideLength = 10;

        double result = _geoOps.CalculateRegularPolygonArea(numSides, sideLength);

        Assert.NotEqual(180, result); // Área incorrecta
    }

    // 20. Pruebas para el perímetro del polígono regular
    [Fact]
    public void CalculateRegularPolygonPerimeter_CorrectResult()
    {
        int numSides = 5;
        double sideLength = 10;

        double result = _geoOps.CalculateRegularPolygonPerimeter(numSides, sideLength);

        Assert.Equal(50, result); // Perímetro esperado
    }

    [Fact]
    public void CalculateRegularPolygonPerimeter_ZeroSides_ReturnsZero()
    {
        int numSides = 0;

        double result = _geoOps.CalculateRegularPolygonPerimeter(numSides, 10);

        Assert.Equal(0, result); // Sin lados, el perímetro debería ser cero
    }

    [Fact]
    public void CalculateRegularPolygonPerimeter_IncorrectResult()
    {
        int numSides = 5;
        double sideLength = 10;
        double result = _geoOps.CalculateRegularPolygonPerimeter(numSides, sideLength);

        Assert.NotEqual(55, result); // Perímetro incorrecto
    }

    // 21. Pruebas para verificar si tres lados pueden formar un triángulo
    [Fact]
    public void CanFormTriangle_ValidTriangle_ReturnsTrue()
    {
        double side1 = 3;
        double side2 = 4;
        double side3 = 5;

        bool result = _geoOps.CanFormTriangle(side1, side2, side3);

        Assert.True(result); // Debe formar un triángulo
    }

    [Fact]
    public void CanFormTriangle_InvalidTriangle_ReturnsFalse()
    {
        double side1 = 1;
        double side2 = 2;
        double side3 = 10;

        bool result = _geoOps.CanFormTriangle(side1, side2, side3);

        Assert.False(result); // No debe formar un triángulo
    }

    [Fact]
    public void CanFormTriangle_ZeroSide_ReturnsFalse()
    {
        double side1 = 0;
        double side2 = 4;
        double side3 = 5;

        bool result = _geoOps.CanFormTriangle(side1, side2, side3);

        Assert.False(result); // Un lado cero no puede formar un triángulo
    }

    // 22. Pruebas para el área del paralelogramo
    [Fact]
    public void CalculateParallelogramArea_CorrectResult()
    {
        double baseLength = 5;
        double height = 10;

        double result = _geoOps.CalculateParallelogramArea(baseLength, height);

        Assert.Equal(50, result); // Área esperada
    }

    [Fact]
    public void CalculateParallelogramArea_ZeroBase_ReturnsZero()
    {
        double baseLength = 0;
        double height = 10;

        double result = _geoOps.CalculateParallelogramArea(baseLength, height);

        Assert.Equal(0, result); // Con base cero, el área es cero
    }

    [Fact]
    public void CalculateParallelogramArea_IncorrectResult()
    {
        double baseLength = 5;
        double height = 10;

        double result = _geoOps.CalculateParallelogramArea(baseLength, height);

        Assert.NotEqual(55, result); // Área incorrecta
    }

    // 23. Pruebas para el perímetro del paralelogramo
    [Fact]
    public void CalculateParallelogramPerimeter_CorrectResult()
    {
        double baseLength = 5;
        double sideLength = 10;

        double result = _geoOps.CalculateParallelogramPerimeter(baseLength, sideLength);

        Assert.Equal(30, result); // Perímetro esperado
    }

    [Fact]
    public void CalculateParallelogramPerimeter_ZeroBase_Returns20()
    {
        double baseLength = 0;
        double sideLength = 10;

        double result = _geoOps.CalculateParallelogramPerimeter(baseLength, sideLength);

        Assert.Equal(20, result); // Con base cero, el perímetro debería ser 2 * sideLength
    }

    [Fact]
    public void CalculateParallelogramPerimeter_IncorrectResult()
    {
        double baseLength = 5;
        double sideLength = 10;

        double result = _geoOps.CalculateParallelogramPerimeter(baseLength, sideLength);

        Assert.NotEqual(35, result); // Perímetro incorrecto
    }

    // 24. Pruebas para verificar si cuatro lados pueden formar un rectángulo
    [Fact]
    public void CanFormRectangle_ValidRectangle_ReturnsTrue()
    {
        double side1 = 5;
        double side2 = 10;
        double side3 = 5;
        double side4 = 10;

        bool result = _geoOps.CanFormRectangle(side1, side2, side3, side4);

        Assert.True(result); // Debe ser un rectángulo
    }

    [Fact]
    public void CanFormRectangle_InvalidRectangle_ReturnsFalse()
    {
        double side1 = 5;
        double side2 = 10;
        double side3 = 5;
        double side4 = 9;

        bool result = _geoOps.CanFormRectangle(side1, side2, side3, side4);

        Assert.False(result); // No debería ser un rectángulo
    }

    [Fact]
    public void CanFormRectangle_ZeroSide_ReturnsFalse()
    {
        double side1 = 0;
        double side2 = 10;
        double side3 = 5;
        double side4 = 10;

        bool result = _geoOps.CanFormRectangle(side1, side2, side3, side4);

        Assert.False(result); // No debería ser un rectángulo
    }

    // 25. Pruebas para la diagonal del rectángulo
    [Fact]
    public void CalculateRectangleDiagonal_CorrectResult()
    {
        double width = 3;
        double height = 4;

        double result = _geoOps.CalculateRectangleDiagonal(width, height);

        Assert.Equal(5, result); // Diagonal esperada
    }

    [Fact]
    public void CalculateRectangleDiagonal_ZeroWidth_ReturnsHeight()
    {
        double height = 10;

        double result = _geoOps.CalculateRectangleDiagonal(0, height);

        Assert.Equal(10, result); // Con cero ancho, diagonal debería ser altura
    }

    [Fact]
    public void CalculateRectangleDiagonal_IncorrectResult()
    {
        double width = 3;
        double height = 4;

        double result = _geoOps.CalculateRectangleDiagonal(width, height);

        Assert.NotEqual(6, result); // Diagonal incorrecta
    }

    // 26. Pruebas para verificar si un conjunto de lados forman un triángulo rectángulo
    [Fact]
    public void IsRightTriangle_ValidRightTriangle_ReturnsTrue()
    {
        double sideA = 3;
        double sideB = 4;
        double hypotenuse = 5;

        bool result = _geoOps.IsRightTriangle(sideA, sideB, hypotenuse);

        Assert.True(result); // Debe ser un triángulo rectángulo
    }

    [Fact]
    public void IsRightTriangle_InvalidRightTriangle_ReturnsFalse()
    {
        double sideA = 3;
        double sideB = 4;
        double hypotenuse = 6;

        bool result = _geoOps.IsRightTriangle(sideA, sideB, hypotenuse);

        Assert.False(result); // No debería ser un triángulo rectángulo
    }

    [Fact]
    public void IsRightTriangle_ZeroSide_ReturnsFalse()
    {
        double sideA = 0;
        double sideB = 4;
        double hypotenuse = 5;

        bool result = _geoOps.IsRightTriangle(sideA, sideB, hypotenuse);

        Assert.False(result); // No debería ser un triángulo rectángulo
    }


    // 27. Pruebas para el área de una elipse
    [Fact]
    public void CalculateEllipseArea_CorrectResult()
    {
        double majorAxis = 10;
        double minorAxis = 5;

        double result = _geoOps.CalculateEllipseArea(majorAxis, minorAxis);

        Assert.Equal(157.1, result, 1); // Área esperada (aproximada)
    }

    [Fact]
    public void CalculateEllipseArea_ZeroMajorAxis_ReturnsZero()
    {
        double minorAxis = 5;

        double result = _geoOps.CalculateEllipseArea(0, minorAxis);

        Assert.Equal(0, result); // Área debería ser cero
    }

    [Fact]
    public void CalculateEllipseArea_IncorrectResult()
    {
        double majorAxis = 10;
        double minorAxis = 5;

        double result = _geoOps.CalculateEllipseArea(majorAxis, minorAxis);

        Assert.NotEqual(160, result); // Área incorrecta
    }

    // 28. Pruebas para el perímetro de una elipse
    [Fact]
    public void CalculateEllipsePerimeter_CorrectResult()
    {
        double majorAxis = 10;
        double minorAxis = 5;

        double result = _geoOps.CalculateEllipsePerimeter(majorAxis, minorAxis);

        Assert.Equal(48.0, result, 1); // Perímetro esperado (aproximado)
    }

    [Fact]
    public void CalculateEllipsePerimeter_ZeroMinorAxis_ReturnsZero()
    {
        double majorAxis = 10;

        double result = _geoOps.CalculateEllipsePerimeter(majorAxis, 0);

        Assert.Equal(0, result); // Con un eje menor cero, perímetro debería ser cero
    }

    [Fact]
    public void CalculateEllipsePerimeter_IncorrectResult()
    {
        double majorAxis = 10;
        double minorAxis = 5;

        double result = _geoOps.CalculateEllipsePerimeter(majorAxis, minorAxis);

        Assert.NotEqual(50, result); // Perímetro incorrecto
    }

    // 29. Pruebas para el área del trapecio isósceles
    [Fact]
    public void CalculateTrapezoidArea_Isosceles_CorrectResult()
    {
        double base1 = 10;
        double base2 = 5;
        double height = 7;

        double result = _geoOps.CalculateTrapezoidArea(base1, base2, height);

        Assert.Equal(52.5, result, 1); // Área esperada (aproximada)
    }

    [Fact]
    public void CalculateTrapezoidArea_Isosceles_ZeroHeight_ReturnsZero()
    {
        double base1 = 10;
        double base2 = 5;

        double result = _geoOps.CalculateTrapezoidArea(base1, base2, 0);

        Assert.Equal(0, result); // Con altura cero, el área debe ser cero
    }

    [Fact]
    public void CalculateTrapezoidArea_Isosceles_IncorrectResult()
    {
        double base1 = 10;
        double base2 = 5;
        double height = 7;

        double result = _geoOps.CalculateTrapezoidArea(base1, base2, height);

        Assert.NotEqual(55, result); // Área incorrecta
    }

    // 30. Pruebas para el perímetro del polígono regular
    [Fact]
    public void CalculateRegularPolygonPerimeter_CorrectResult1()
    {
        int numSides = 6;
        double sideLength = 10;

        double result = _geoOps.CalculateRegularPolygonPerimeter(numSides, sideLength);

        Assert.Equal(60, result); // Perímetro esperado
    }

    [Fact]
    public void CalculateRegularPolygonPerimeter_ZeroSides_ReturnsZero1()
    {
        double sideLength = 10;

        double result = _geoOps.CalculateRegularPolygonPerimeter(0, sideLength);

        Assert.Equal(0, result); // Sin lados, el perímetro debería ser cero
    }

    [Fact]
    public void CalculateRegularPolygonPerimeter_IncorrectResult1()
    {
        int numSides = 6;
        double sideLength = 10;

        double result = _geoOps.CalculateRegularPolygonPerimeter(numSides, sideLength);

        Assert.NotEqual(70, result); // Perímetro incorrecto
    }

    // 31. Pruebas para la longitud de la hipotenusa usando el Teorema de Pitágoras
    [Fact]
    public void CalculateHypotenuse_CorrectResult()
    {
        double sideA = 3;
        double sideB = 4;

        double result = _geoOps.CalculateHypotenuse(sideA, sideB);

        Assert.Equal(5, result); // Hipotenusa esperada
    }

    [Fact]
    public void CalculateHypotenuse_ZeroSide_ReturnsZero()
    {
        double sideB = 4;

        double result = _geoOps.CalculateHypotenuse(0, sideB);

        Assert.Equal(0, result); // Con un lado cero, la hipotenusa debe ser cero
    }


    // 33. Pruebas para el volumen del cilindro con radio cero
    [Fact]
    public void CalculateCylinderVolume_ZeroRadius_ReturnsZero()
    {
        double height = 10;

        double result = _geoOps.CalculateCylinderVolume(0, height);

        Assert.Equal(0, result); // Con radio cero, el volumen es cero
    }


    // 28. Pruebas para verificar si tres ángulos pueden formar un triángulo (suma de 180 grados)
    [Fact]
    public void CanFormTriangleFromAngles_ValidAngles_ReturnsTrue()
    {
        double angle1 = 60;
        double angle2 = 60;
        double angle3 = 60;

        bool result = _geoOps.CanFormTriangleFromAngles(angle1, angle2, angle3);

        Assert.True(result); // Deben sumar 180 grados
    }

    [Fact]
    public void CanFormTriangleFromAngles_InvalidAngles_ReturnsFalse()
    {
        double angle1 = 90;
        double angle2 = 90;
        double angle3 = 10;

        bool result = _geoOps.CanFormTriangleFromAngles(angle1, angle2, angle3);

        Assert.False(result); // No deben formar un triángulo
    }

    [Fact]
    public void CanFormTriangleFromAngles_ZeroAngle_ReturnsFalse1()
    {
        double angle1 = 0;
        double angle2 = 60;
        double angle3 = 60;

        bool result = _geoOps.CanFormTriangleFromAngles(angle1, angle2, angle3);

        Assert.False(result); // Ángulos no pueden ser cero
    }

    // 29. Pruebas para el área superficial del cono

    [Fact]
    public void CalculateConeSurfaceArea_ZeroRadius_ReturnsZero()
    {
        double slantHeight = 10;

        double result = _geoOps.CalculateConeSurfaceArea(0, slantHeight);

        Assert.Equal(0, result);
    }

    [Fact]
    public void CalculateConeSurfaceArea_IncorrectResult()
    {
        double radius = 5;
        double slantHeight = 10;

        double incorrectSurfaceArea = 240;

        double result = _geoOps.CalculateConeSurfaceArea(radius, slantHeight);

        Assert.NotEqual(incorrectSurfaceArea, result);
    }

    // 31. Pruebas para el tercer lado usando la Ley del Coseno


    [Fact]
    public void CalculateThirdSideLawOfCosines_ZeroSide_ReturnsZero()
    {
        double sideB = 8;
        double angleDegrees = 45;

        double result = _geoOps.CalculateThirdSideLawOfCosines(0, sideB, angleDegrees);

        Assert.Equal(0, result); // Con un lado cero, el tercer lado es cero
    }

    [Fact]
    public void CalculateThirdSideLawOfCosines_IncorrectResult()
    {
        double sideA = 7;
        double sideB = 8;
        double angleDegrees = 45;

        double incorrectThirdSide = 6.0;

        double result = _geoOps.CalculateThirdSideLawOfCosines(sideA, sideB, angleDegrees);

        Assert.NotEqual(incorrectThirdSide, result);
    }

    // 32. Pruebas para el ángulo usando la Ley del Coseno


    [Fact]
    public void CalculateAngleLawOfCosines_IncorrectResult()
    {
        double sideA = 7;
        double sideB = 8;
        double sideC = 10;

        double incorrectAngle = 0.7; // Valor incorrecto

        double result = _geoOps.CalculateAngleLawOfCosines(sideA, sideB, sideC);

        Assert.NotEqual(incorrectAngle, result, 2);
    }


    [Fact]
    public void CalculateSideLawOfSines_IncorrectResult()
    {
        double angleA = 30;
        double sideA = 8;
        double angleB = 45;

        double incorrectSide = 12; // Valor incorrecto

        double result = _geoOps.CalculateSideLawOfSines(angleA, sideA, angleB);

        Assert.NotEqual(incorrectSide, result, 1);
    }

    [Fact]
    public void CalculateSideLawOfSines_ZeroSide_ReturnsInvalid()
    {
        double angleB = 45;

        double result = _geoOps.CalculateSideLawOfSines(30, 0, angleB);

        Assert.Equal(double.NaN, result); // Con un lado cero, el resultado es inválido
    }

    // 34. Pruebas para el ángulo usando la Ley del Seno


    [Fact]
    public void CalculateAngleLawOfSines_IncorrectResult()
    {
        double angleA = 30;
        double angleB = 60;
        double sideC = 10;

        double incorrectAngle = 35; // Valor incorrecto

        double result = _geoOps.CalculateAngleLawOfSines(angleA, angleB, sideC);

        Assert.NotEqual(incorrectAngle, result, 1);
    }

    [Fact]
    public void CalculateAngleLawOfSines_ZeroSide_ReturnsInvalid()
    {
        double angleB = 60;

        double result = _geoOps.CalculateAngleLawOfSines(30, angleB, 0);

        Assert.Equal(double.NaN, result); // Con un lado cero, resultado es inválido
    }

    // 35. Pruebas para el área del triángulo usando la Ley del Coseno

    [Fact]
    public void CalculateTriangleAreaWithCosine_IncorrectResult()
    {
        double sideA = 5;
        double sideB = 6;
        double angleDegrees = 45;

        double incorrectArea = 11; // Valor incorrecto

        double result = _geoOps.CalculateTriangleAreaWithCosine(sideA, sideB, angleDegrees);

        Assert.NotEqual(incorrectArea, result, 1);
    }

    [Fact]
    public void CalculateTriangleAreaWithCosine_ZeroAngle_ReturnsInvalid()
    {
        double sideB = 6;

        double result = _geoOps.CalculateTriangleAreaWithCosine(5, sideB, 0);

        Assert.Equal(0, result); // Con un ángulo cero, el resultado debe ser cero
    }


    // 28. Pruebas para comprobar si tres ángulos pueden formar un triángulo
    [Fact]
    public void CanFormTriangleFromAngles_Valid_ReturnsTrue()
    {
        double angle1 = 60;
        double angle2 = 60;
        double angle3 = 60;

        bool result = _geoOps.CanFormTriangleFromAngles(angle1, angle2, angle3);

        Assert.True(result); // Ángulos que suman 180 grados
    }

    [Fact]
    public void CanFormTriangleFromAngles_Invalid_ReturnsFalse()
    {
        double angle1 = 90;
        double angle2 = 90;
        double angle3 = 10;

        bool result = _geoOps.CanFormTriangleFromAngles(angle1, angle2, angle3);

        Assert.False(result); // No suman 180 grados
    }

    [Fact]
    public void CanFormTriangleFromAngles_ZeroAngle_ReturnsFalse()
    {
        double angle1 = 0;
        double angle2 = 90;
        double angle3 = 90;

        bool result = _geoOps.CanFormTriangleFromAngles(angle1, angle2, angle3);

        Assert.False(result); // No pueden tener ángulos cero
    }

    // 29. Pruebas para el área superficial del cono
    [Fact]
    public void CalculateConeSurfaceArea_Correct_ReturnsExpected()
    {
        double radius = 5;
        double slantHeight = 10;

        double expectedSurfaceArea = 235.6; // Aproximadamente

        double result = _geoOps.CalculateConeSurfaceArea(radius, slantHeight);

        Assert.Equal(expectedSurfaceArea, result, 1);
    }


    [Fact]
    public void CalculateConeSurfaceArea_Incorrect_ReturnsNotExpected()
    {
        double radius = 5;
        double slantHeight = 10;

        double incorrectSurfaceArea = 240; // Valor incorrecto

        double result = _geoOps.CalculateConeSurfaceArea(radius, slantHeight);

        Assert.NotEqual(incorrectSurfaceArea, result, 1);
    }

    // 31. Pruebas para encontrar el tercer lado usando la Ley del Coseno
    [Fact]
    public void CalculateThirdSideLawOfCosines_Correct_ReturnsExpected()
    {
        double sideA = 7;
        double sideB = 8;
        double angleDegrees = 45;

        double expectedThirdSide = 4.5; // Aproximadamente

        double result = _geoOps.CalculateThirdSideLawOfCosines(sideA, sideB, angleDegrees);

        Assert.Equal(expectedThirdSide, result, 1);
    }


    [Fact]
    public void CalculateThirdSideLawOfCosines_Incorrect_ReturnsNotExpected()
    {
        double sideA = 7;
        double sideB = 8;
        double angleDegrees = 45;

        double incorrectThirdSide = 6.0; // Valor incorrecto

        double result = _geoOps.CalculateThirdSideLawOfCosines(sideA, sideB, angleDegrees);

        Assert.NotEqual(incorrectThirdSide, result, 1);
    }

    // 32. Pruebas para encontrar un ángulo usando la Ley del Coseno
    [Fact]
    public void CalculateAngleLawOfCosines_Correct_ReturnsExpected()
    {
        double sideA = 7;
        double sideB = 8;
        double sideC = 10;

        double expectedAngle = 0.64; // Aproximadamente

        double result = _geoOps.CalculateAngleLawOfCosines(sideA, sideB, sideC);

        Assert.Equal(expectedAngle, result, 2); // Con precisión de dos decimales
    }

    [Fact]
    public void CalculateAngleLawOfCosines_Incorrect_ReturnsNotExpected()
    {
        double sideA = 7;
        double sideB = 8;
        double sideC = 10;

        double incorrectAngle = 0.7; // Valor incorrecto

        double result = _geoOps.CalculateAngleLawOfCosines(sideA, sideB, sideC);

        Assert.NotEqual(incorrectAngle, result, 2);
    }


    // 33. Pruebas para el lado usando la Ley del Seno
    [Fact]
    public void CalculateSideLawOfSines_Correct_ReturnsExpected()
    {
        double angleA = 30;
        double sideA = 8;
        double angleB = 45;

        double expectedSide = 11.3; // Aproximadamente

        double result = _geoOps.CalculateSideLawOfSines(angleA, sideA, angleB);

        Assert.Equal(expectedSide, result, 1);
    }

    [Fact]
    public void CalculateSideLawOfSines_ZeroSide_ReturnsZero()
    {
        double angleB = 45;

        double result = _geoOps.CalculateSideLawOfSines(30, 0, angleB);

        Assert.Equal(0, result); // Con un lado cero, resultado es cero
    }

    [Fact]
    public void CalculateSideLawOfSines_Incorrect_ReturnsNotExpected()
    {
        double angleA = 30;
        double sideA = 8;
        double angleB = 45;

        double incorrectSide = 12; // Valor incorrecto

        double result = _geoOps.CalculateSideLawOfSines(angleA, sideA, angleB);

        Assert.NotEqual(incorrectSide, result, 1);
    }

    // 34. Pruebas para el ángulo usando la Ley del Seno
    [Fact]
    public void CalculateAngleLawOfSines_Correct_ReturnsExpected()
    {
        double angleA = 30;
        double angleB = 60;
        double sideC = 10;

        double expectedAngle = 30; // Aproximadamente

        double result = _geoOps.CalculateAngleLawOfSines(angleA, angleB, 10);

        Assert.Equal(expectedAngle, result, 1);
    }

    [Fact]
    public void CalculateAngleLawOfSines_ZeroSide_ReturnsZero()
    {
        double angleA = 30;

        double result = _geoOps.CalculateAngleLawOfSines(angleA, angleA, 0);

        Assert.Equal(0, result);
    }

    [Fact]
    public void CalculateAngleLawOfSines_Incorrect_ReturnsNotExpected()
    {
        double angleA = 30;
        double angleB = 60;
        double sideC = 10;

        double incorrectAngle = 35; // Valor incorrecto

        double result = _geoOps.CalculateAngleLawOfSines(angleA, angleB, sideC);

        Assert.NotEqual(incorrectAngle, result, 1);
    }

    // 35. Pruebas para el área del triángulo utilizando la Ley del Coseno
    [Fact]
    public void CalculateTriangleAreaWithCosine_Correct_ReturnsExpected()
    {
        double sideA = 5;
        double sideB = 6;
        double angleDegrees = 45;

        double expectedArea = 10.6; // Aproximadamente

        double result = _geoOps.CalculateTriangleAreaWithCosine(sideA, sideB, angleDegrees);

        Assert.Equal(expectedArea, result, 1);
    }

    [Fact]
    public void CalculateTriangleAreaWithCosine_ZeroAngle_ReturnsZero()
    {
        double sideA = 5;
        double sideB = 6;

        double result = _geoOps.CalculateTriangleAreaWithCosine(5, sideB, 0);

        Assert.Equal(0, result); // Con ángulo cero, el área debe ser cero
    }

    [Fact]
    public void CalculateTriangleAreaWithCosine_Incorrect_ReturnsNotExpected()
    {
        double sideA = 5;
        double sideB = 6;
        double angleDegrees = 45;

        double incorrectArea = 11; // Valor incorrecto

        double result = _geoOps.CalculateTriangleAreaWithCosine(sideA, sideB, angleDegrees);

        Assert.NotEqual(incorrectArea, result, 1);
    }

    // Prueba para el área superficial del cono
    [Fact]
    public void CalculateConeSurfaceArea_CorrectResult()
    {
        double radius = 5;
        double slantHeight = 10;

        double expectedSurfaceArea = 235.6; // Valor esperado

        double result = _geoOps.CalculateConeSurfaceArea(radius, slantHeight);

        Assert.Equal(expectedSurfaceArea, result, 1); // Con precisión de un decimal
    }

    // Prueba para el tercer lado usando la Ley del Coseno
    [Fact]
    public void CalculateThirdSideLawOfCosines_CorrectResult()
    {
        double sideA = 7;
        double sideB = 8;
        double angleDegrees = 45;

        double expectedThirdSide = 4.5; // Valor esperado

        double result = _geoOps.CalculateThirdSideLawOfCosines(sideA, sideB, angleDegrees);

        Assert.Equal(expectedThirdSide, result, 1);
    }

    // Prueba para encontrar un ángulo usando la Ley del Coseno
    [Fact]
    public void CalculateAngleLawOfCosines_CorrectResult()
    {
        double sideA = 7;
        double sideB = 8;
        double sideC = 10;

        double expectedAngle = 0.64; // Valor esperado en radianes

        double result = _geoOps.CalculateAngleLawOfCosines(sideA, sideB, sideC);

        Assert.Equal(expectedAngle, result, 2); // Con precisión de dos decimales
    }

    // Prueba para encontrar un lado usando la Ley del Seno
    [Fact]
    public void CalculateSideLawOfSines_CorrectResult()
    {
        double angleA = 30;
        double sideA = 8;
        double angleB = 45;

        double expectedSide = 11.3; // Valor esperado

        double result = _geoOps.CalculateSideLawOfSines(angleA, sideA, angleB);

        Assert.Equal(expectedSide, result, 1);
    }

    // Prueba para encontrar un ángulo usando la Ley del Seno
    [Fact]
    public void CalculateAngleLawOfSines_CorrectResult()
    {
        double angleA = 30;
        double angleB = 60;
        double sideC = 10;

        double expectedAngle = 30; // Valor esperado en grados

        double result = _geoOps.CalculateAngleLawOfSines(angleA, angleB, sideC);

        Assert.Equal(expectedAngle, result, 1);
    }

    // Prueba para el área del triángulo usando la Ley del Coseno
    [Fact]
    public void CalculateTriangleAreaWithCosine_CorrectResult()
    {
        double sideA = 5;
        double sideB = 6;
        double angleDegrees = 45;

        double expectedArea = 10.6; // Valor esperado

        double result = _geoOps.CalculateTriangleAreaWithCosine(sideA, sideB, angleDegrees);

        Assert.Equal(expectedArea, result, 1);
    }


    // Pruebas para calcular el área del triángulo utilizando la Ley del Seno
    [Fact]
    public void CalculateTriangleAreaWithSines_CorrectResult()
    {
        double angleA = 45;
        double sideA = 7;
        double sideB = 8;

        double expectedArea = 19.79; // Valor esperado

        double result = _geoOps.CalculateTriangleAreaWithSines(angleA, sideA, sideB);

        Assert.Equal(expectedArea, result, 2); // Con precisión de dos decimales
    }

    [Fact]
    public void CalculateTriangleAreaWithSines_ZeroAngle_ReturnsZero()
    {
        double sideA = 7;
        double sideB = 8;

        double result = _geoOps.CalculateTriangleAreaWithSines(0, sideA, sideB);

        Assert.Equal(0, result); // Con ángulo cero, el área debería ser cero
    }

    [Fact]
    public void CalculateTriangleAreaWithSines_IncorrectResult()
    {
        double angleA = 45;
        double sideA = 7;
        double sideB = 8;

        double incorrectArea = 20.0; // Valor incorrecto

        double result = _geoOps.CalculateTriangleAreaWithSines(angleA, sideA, sideB);

        Assert.NotEqual(incorrectArea, result, 2); // No debería ser 20.0
    }

    // Pruebas para comprobar si un ángulo es un ángulo recto utilizando la Ley del Coseno
    [Fact]
    public void IsRightAngleWithCosines_ValidRightAngle_ReturnsTrue()
    {
        double sideA = 3;
        double sideB = 4;
        double sideC = 5;

        bool result = _geoOps.IsRightAngleWithCosines(sideA, sideB, sideC);

        Assert.True(result); // Debería ser un ángulo recto
    }

    [Fact]
    public void IsRightAngleWithCosines_InvalidRightAngle_ReturnsFalse()
    {
        double sideA = 3;
        double sideB = 4;
        double sideC = 6;

        bool result = _geoOps.IsRightAngleWithCosines(sideA, sideB, sideC);

        Assert.False(result); // No debería ser un ángulo recto
    }

    [Fact]
    public void IsRightAngleWithCosines_ZeroSide_ReturnsFalse()
    {
        double sideB = 4;
        double sideC = 5;

        bool result = _geoOps.IsRightAngleWithCosines(0, sideB, sideC);

        Assert.False(result); // Con un lado cero, no hay ángulo recto
    }

    // Pruebas para calcular la altura del triángulo utilizando la Ley del Coseno
    [Fact]
    public void CalculateTriangleHeightWithCosines_CorrectResult()
    {
        double sideA = 7;
        double angleDegrees = 45;

        double expectedHeight = 4.95; // Valor esperado

        double result = _geoOps.CalculateTriangleHeightWithCosines(sideA, angleDegrees);

        Assert.Equal(expectedHeight, result, 2); // Con precisión de dos decimales
    }

    [Fact]
    public void CalculateTriangleHeightWithCosines_ZeroAngle_ReturnsZero()
    {
        double sideA = 7;

        double result = _geoOps.CalculateTriangleHeightWithCosines(sideA, 0);

        Assert.Equal(0, result); // Con ángulo cero, la altura debería ser cero
    }

    [Fact]
    public void CalculateTriangleHeightWithCosines_IncorrectResult()
    {
        double sideA = 7;
        double angleDegrees = 45;

        double incorrectHeight = 5.5; // Valor incorrecto

        double result = _geoOps.CalculateTriangleHeightWithCosines(sideA, angleDegrees);

        Assert.NotEqual(incorrectHeight, result, 2);
    }

    // Pruebas para comprobar si tres lados pueden formar un triángulo utilizando la Ley del Coseno
    [Fact]
    public void CanFormTriangleWithCosines_Valid_ReturnsTrue()
    {
        double sideA = 7;
        double sideB = 8;
        double sideC = 10;

        bool result = _geoOps.CanFormTriangleWithCosines(sideA, sideB, sideC);

        Assert.True(result); // Deberían poder formar un triángulo
    }

    [Fact]
    public void CanFormTriangleWithCosines_Invalid_ReturnsFalse()
    {
        double sideA = 3;
        double sideB = 3;
        double sideC = 10;

        bool result = _geoOps.CanFormTriangleWithCosines(sideA, sideB, sideC);

        Assert.False(result); // No deberían formar un triángulo
    }

    [Fact]
    public void CanFormTriangleWithCosines_ZeroSide_ReturnsFalse()
    {
        double sideA = 0;
        double sideB = 8;
        double sideC = 10;

        bool result = _geoOps.CanFormTriangleWithCosines(sideA, sideB, sideC);

        Assert.False(result); // Con un lado cero, no se forma un triángulo
    }


    // Pruebas para calcular el perímetro del triángulo usando la Ley del Coseno
    [Fact]
    public void CalculateTrianglePerimeterWithCosines_CorrectResult()
    {
        double sideA = 7;
        double sideB = 8;
        double sideC = 10;

        double expectedPerimeter = 25; // Valor esperado

        double result = _geoOps.CalculateTrianglePerimeterWithCosines(sideA, sideB, sideC);

        Assert.Equal(expectedPerimeter, result);
    }

    [Fact]
    public void CalculateTrianglePerimeterWithCosines_ZeroSide_ReturnsZero()
    {
        double sideB = 8;
        double sideC = 10;

        double result = _geoOps.CalculateTrianglePerimeterWithCosines(0, sideB, sideC);

        Assert.Equal(0, result); // Con un lado cero, el perímetro debe ser cero
    }

    [Fact]
    public void CalculateTrianglePerimeterWithCosines_IncorrectResult()
    {
        double sideA = 7;
        double sideB = 8;
        double sideC = 10;

        double incorrectPerimeter = 30; // Valor incorrecto

        double result = _geoOps.CalculateTrianglePerimeterWithCosines(sideA, sideB, sideC);

        Assert.NotEqual(incorrectPerimeter, result); // No debería ser 30
    }
}