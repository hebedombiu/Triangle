## Использование
`double Triangle.Triangle.GetTriangleType(double a, double b, double c);`

### Параметры
a, b, c - длины сторон треугольника

### Возвращает
тип треугольника, где:
* value &gt; 0: треугольник с тупым углом
* value &lt; 0: треугольник с острыми углами
* value == 0: прямоугольный треугольник