# Shapes
1. Площади фигур могут вычисляться без знания типа в compile-time за счет наследования абстрактного метода GetArea().
2. Для добавления фигур достаточно отнаследоваться от Shape. Можно при желании добавить дополнительные промежуточные классы (типа IPolygone или ITriangle), но задание этого не требует (к тому же в чем смысл проверки на прямоугольность, если заранее есть класс для прямоугольных треугольников).
3. Добавлены юнит-тесты.

Ссылка на задание 2: http://sqlfiddle.com/#!18/7da78e/1
Также прикреплен файл с самим запросом.