Необходимо написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равано 3 символам. Пепрвоначальный массив можно ввести с клавиатуры, либо задть на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллециями, лучше обойтись исключительно массивами.

Алгоритм:
1. Для решения задачи создадим функцию, которая будет принимать на вход строковый массив и возвращать кол-во элементов, длина которых меньше или ровна 3. 
// int ArrayLen(string[] array)

2. Далее нам потребуется создать еще одну функцию, которая будет принимать на вход строковый массив и кол-во элементов, длина которых меньше или ровна 3, куда задаем длину нового массива с подходящими под условие элементами, которые получили с предыдущей функции.
// string[] GenerateNewArray(string[] array, int count)

3. Создаем функцию, которая будет принимать массив и выводить его на экран.
// void Printarray(string[] array, int number)