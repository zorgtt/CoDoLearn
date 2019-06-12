﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Data
{
    private static string[] questionsC = { "Для чего нужен тип std::auto_ptr<T>?", "Что такое статический элемент?", "В чем разница между массивом и списком?", "Что такое виртуальная функция?", "Какое ключевое используется для создания виртуального метода.", "Для какой цели применяется ключевое слово const?", "Как защитить объект от копирования?", "Сколько в памяти занимает произвольная структура?", "Как сгенерировать pure virtual function call исключение?", "Что дают разные модификаторы при наследовании?", "Что такое полиморфизм?", "Для чего используется вызов throw без аргументов?", " Для чего используется ключевое слово volatile?", "Что делает оператор «%»", "Какой оператор возвращает значение из метода ?" , "Для чего нужен тип std::auto_ptr<T>?" };
    private static string[] questionsJavaScript = { "Что вернет вызов функции parseInt(08)?", "Что означает атрибут defer в теге <script>?", "Допустимо ли использование инструкции try/catch/finally без блока catch?", "Укажите все способ указания комментариев в javascript-коде.", "Какие из этих операторов выполняет не только арифметические операции?", "Что выведет на экран следующий код? alert(Math.floor(Math.random());", "Как правильно писать IF конструкцию в JavaScript?", "Сколько разных ключевых слов для описания циклов доступно в javascript?", "Как правильно написать IF конструкцию, чтобы выполнялся некоторый код, когда i не равно 5.", "Нужно добавить в стандартный JavaScript объект String метод compareTo().Что должно для этого быть вставлено?", "Что делает функция alert?", "Каким будет результат?var a = new Array(5).join('5'); ", "Что делает оператор **?", "Какое из этих слов не имеет специального использования в JavaScript, никак не упомянуто в стандарте?", "Верно ли сравнение: ёжик > яблоко?", "Что вернет вызов функции parseInt(08)?" };
    private static string[] questionsJava = { "Какое из следующих утверждений верно для класса: java.util.ArrayList?", "Какое из следующих утверждений верно для method-local inner class?", "Какое из следующих утверждений верно?", "Можно ли из метода некоторого класса напрямую обратиться к приватному методу другого экземпляра этого же класса?", "Какая максимальная длина имени переменной допустима в Java в соответствии со спецификацией?", "Выберите верный вариант объявления метода main (java 5 и выше).", "Что делает метод equals()", "Как правильно организовать доступ к полям класса?", "О чем говорит ключевое слово “this”?", "О чем говорит ключевое слово “super”", "Что значит слово “инициализация”?", "На какие основные группы можно поделить типы данных?", "Что такое “итерация цикла”?", "Что такое автоупаковка (boxing и unboxing)?", "Какой оператор используется для немедленной остановки цикла?", "Какое из следующих утверждений верно для класса: java.util.ArrayList?" };
    private static string[] questionsSharp = { "Где правильно создан массив?", "Что делает try-catch?", "Какая функция сравнивает две подстроки?", "Как сделать инкрементацию числа?" , "Как сделать декрементация числа?", "Где правильно создана переменная?", "Чему будет равен с, если int a = 10; int b = 4; int c = a % b?", "Чему будет равен с, если int a = 10; int b = 4; bool c = (a == 10 && b == 4)?", "В чем отличие между break и continue?", "Обозначение оператора «ИЛИ»", " Как называется оператор «?:»", "Чему будет равен с, если int a = 0; int c = a-- ?", "Когда и почему использовать StringBuilder предпочтительнее чем string?", "Где правильно создан массив?", "Что делает try-catch?" , "Чему равен d, если int a = 0; int b = a++; int c = 0; int d = a + b + c + 3 ?"};

    private static string[][] answersC = { new string[] { "Для создания класса", "Для создания автономных классов", "Для создания статического класса", "Чтоб после каждого new был вызван свой delete" }, new string[] { "Static – ключевое слово, используемое для придания элементу уникальных характеристик.", "Константные поля", "Елемент который не удаляеться деструктором", "Переменная с значением по умолчанию" }, new string[] { "На массив не может быть указателя, а на список может быть", "Массив значемый тип данных, а список ссылочный", "Список и имеет статическую длинну, а массив нет", "Массив – это набор однородных элементов, а список – разнородных." }, new string[] { "Виртуальная функция – это свойство, для замены значений полей, предоставляемого базовым классом.", "Виртуальная функция – это класс, который используется для замены реализованию интерфейса", "Виртуальная функция – это метод, который используется в рантайме для замены реализованного функционала, предоставляемого базовым классом.", "Виртуальная функция – это метод, который используется на этапе компиляции для замены реализованного функционала, предоставляемого базовым классом." }, new string[] { "static", "virtual", "new", "const" }, new string[] { "Позволяет указать, что данное поле модифицирует члены класса", "Позволяет указать, что данный метод модифицирует члены класса", "Позволяет задать константность объекта", "Для того что бы задавать начальное значение в конструкторе" }, new string[] { "Сделать internal конструктор", "Сделать private конструктор копирования и оператор =.", "Не переопределять оператор =", "Скрыть класс" }, new string[] { "sizeof всех членов + остаток для выравнивания", "20 байтов", "sizeof всех членов", "sizeof всех членов умноженное на 2" }, new string[] { "Нужно вызвать скрытый метод в приватном конструкторе родительского класса", "Нужно вызвать абстрактный метод в конструкторе родительского класса", "Нужно вызвать чисто виртуальный метод в конструкторе родительского класса", "Нужно вызвать чисто виртуальный метод в конструкторе класса наследника" }, new string[] { "Изменяют зону видимости сборки.", "Изменяют зону видимости членов базового класса.", "Изменяют зону видимости членов внутри базового класса.", "Изменяют зону видимости членов только в одной сборке всех классов." }, new string[] { "Возможность объектов с различной спецификацией иметь различную реализацию.", "Невозможность объектов с одинаковой спецификацией иметь различную реализацию.", "Возможность объектов с одинаковой спецификацией иметь одинаковою реализацию.", "Возможность объектов с одинаковой спецификацией иметь различную реализацию." }, new string[] { "Для повторного возбуждения предыдущего исключения и направления его следующему обработчику.", "Для возбуждения исключения.", "Для скрытия метода от других классов", "Для переопределения методов для базового класса" }, new string[] { "Для указания компилятору, что доступ к переменной не может осуществляться из мест, неподконтрольных ему.", "Для указания интерпретатору, что доступ к переменной может осуществляться из мест, неподконтрольных ему.", "Для указания компилятору, что доступ к переменной может осуществляться из мест, подконтрольных ему.", "Для указания компилятору, что доступ к переменной может осуществляться из мест, неподконтрольных ему." }, new string[] { "Сравнение двух объектов", "Умножение двух объектов", "Находит остаток от деления", "Создает ссылку на объект" }, new string[] { "goto", "stop", "break", "return" } , new string[] { "Для создания класса", "Для создания автономных классов", "Для создания статического класса", "Чтоб после каждого new был вызван свой delete" } };
    private static string[][] answersJavaScript = { new string[] { "NaN", "Зависит от движка браузера", "0", "08" },  new string[] { "Такого атрибута не существует", "Страница не будет ожидать загрузки и выполнения скрипта, скрипт выполнится только после того, как весь HTML-документ будет обработан браузером", "Страница не будет ожидать загрузки", "Страница не будет ожидать загрузки и выполнения скрипта, скрипт выполнится, как только полностью будет загружен" }, new string[] { "да", "нет", "иногда", "такого синтаксиса нету" }, new string[] { "//комментарий", "%/комментарий/%", "@комментарий", "(комментарий)" }, new string[] { "/", "%", "*", "+" }, new string[] { "null", "0", "1", "Math.random" }, new string[] { "if i == 5 then", "if i = 5", "if i = 5 then", "if (i == 5)" }, new string[] { "Три: for, while и do...while", "Два: for и while", "Одно: for", "Четыре: for, while, do...while и foreach" }, new string[] { "if (i <> 5)", "if i <> 5", "if i =! 5 then", "if (i != 5)" }, new string[] { "prototype", "Object", "unit", "compareble" }, new string[] { "Сравнивает типы", "Выводит окно", "Меняет цвет", "Выбрасывает ошибку" }, new string[] { "55555", "5555", "0", "undefined" }, new string[] { "Возводит в степень.", "Умножает число само на себя.", "Нет такого оператора.", "Делит" }, new string[] { "parent", "constructor", "this", "new" }, new string[] { "нет", "да", "Зависит от локальных настроек браузера.", "Зависит от среды разработки" } , new string[] { "NaN", "Зависит от движка браузера", "0", "08" } };
    private static string[][] answersJava = { new string[] { "Коллекция гарантированно неизменная (immutable).", "Элементы в коллекции доступны с помощью уникального ключа.", "Элементы в коллекции упорядочены.", "Элементы коллекции гарантированно уникальные." }, new string[] { "Должен быть объявлен как final", "Может быть объявлен как public.", "Может быть объявлен как finalabstract.", "Может быть объявлен как static." }, new string[] { "В assert statement, выражение после (:) может быть произвольным выражением Java.", "Если switch блока нет default, считается подходящим добавление assert default.", "В assert statement, Если выражение после двоеточие (: ) нет значения, assert's error message будет пустым.", "Подходящий способ для перехвата assertion failure будет через catch clause" }, new string[] { "Нет, можно вызывать только public", "Нет, можно вызывать только public и protected", "Да, можно", "Одни методы не могут вызывать другие методы" }, new string[] { "256 символов", "1024 символа", " 8 бит", "не ограничена" }, new string[] { "public void main(String args[])", "public static int main{String args[]}", "public static void main(String ... args)", "public static int main(String args[])" }, new string[] { "Сравнивает объекты", "Удаляет объект", "Добавляет в коллекцию", "Изменяет объект" }, new string[] { "Через модификатор protected", "Доступ через свойства get, set", "Через модификатор public", "Модификатор доступа — private. Доступ через методы get, set." }, new string[] { "Используется для обращения к текущему классу", "Обращение к классу родителю", "Скрыть этот класс от наследников", "Переопределить класс" }, new string[] { "Используется для обращения к классу наследнику", "Используется для обращения к базовому классу", "Определяет константу", "Скрывает метод" }, new string[] { "Создание, активация, подготовка к работе, определение параметров. ", "Сокрытие данных", "Реализация интерфейсов", "Остановка метода" }, new string[] { "Значимые и примитивные", "Черные и белые", "Примитивные и ссылочные", "Целые и дробные" }, new string[] { "Пропуск шага", "Продолжение цикла", "Это одноразовое выполнение кода, размещенного в теле цикла.", "Остановка цикла" }, new string[] { "Преобразование из примитивных типов данных к ссылочным и наоборот.", "Создание ссылки на ссылку или метод", "Преобразование примитивных типов в целочисленные типы", "ans 4" }, new string[] { "reset", "break", "stop", "goto" } , new string[] { "Коллекция гарантированно неизменная (immutable).", "Элементы в коллекции доступны с помощью уникального ключа.", "Элементы в коллекции упорядочены.", "Элементы коллекции гарантированно уникальные." } };
    private static string[][] answersSharp = { new string[] { "int arr[] = {2, 5};", "int arr = {2, 5};", "int[] arr = new Array [2, 5];", "int[] arr = new int [2] {2, 5};" }, new string[] { "Работает с исключениями", "Работает с файлами", "Работает с классами", "Работает с базой данных" }, new string[] { "String.Check (”hi”, ”hello”);", " String.Equal (”hi”, ”hello”);", "String.Match (”hi”, ”hello”);", "String.Compare (”hi”, ”hello”);" }, new string[] { "++", "--", "==", "%*" }, new string[] { "*?", "%", "--", "++" }, new string[] { "var x;", "int num = ”1”;", " float big_num = 23.2234;", "char symbol = 'A';" }, new string[] { "1", "2", "4", "3" }, new string[] { "false", "0", "null", "true" }, new string[] { "Нет отличий;", "Break работает только в циклах, continue не только;", "Break используется в Switch case, а continue в циклах;", "Continue пропускает итерацию, break выходит из цикла" }, new string[] { "~", "^", "||", "&&" }, new string[] { "унарный", "тернарный", "итератор", "вопросный" }, new string[] { "-1", "0", "-2", "2" }, new string[] { "Если строка редко изменяется", "Если строка часто изменяется", "Если строка содержит спецсимволы", "Если строка содержит исключительно цифры" }, new string[] { "int arr[] = {2, 5};", "int arr = {2, 5};", "int[] arr = new Array [2, 5];", "int[] arr = new int [2] {2, 5};" }, new string[] { "Работает с исключениями", "Работает с файлами", "Работает с классами", "Работает с базой данных" } ,new string[] { "true","false","0","3"} };

    private static string[] rightAnswersC = { "Чтоб после каждого new был вызван свой delete", "Static – ключевое слово, используемое для придания элементу уникальных характеристик.", "Массив – это набор однородных элементов, а список – разнородных.", "Виртуальная функция – это метод, который используется в рантайме для замены реализованного функционала, предоставляемого базовым классом.", "virtual", "Позволяет задать константность объекта", "Сделать private конструктор копирования и оператор =.", "sizeof всех членов + остаток для выравнивания", "Нужно вызвать чисто виртуальный метод в конструкторе родительского класса", "Изменяют зону видимости членов базового класса.", "Возможность объектов с одинаковой спецификацией иметь различную реализацию.", "Для повторного возбуждения предыдущего исключения и направления его следующему обработчику.", "Для указания компилятору, что доступ к переменной может осуществляться из мест, неподконтрольных ему.", "Находит остаток от деления", "return" , "Чтоб после каждого new был вызван свой delete" };
    private static string[] rigthAnswersJavaScript = { "Зависит от движка браузера", "Страница не будет ожидать загрузки и выполнения скрипта, скрипт выполнится только после того, как весь HTML-документ будет обработан браузером", "да", "//комментарий", "+", "0", "if (i == 5)", "Три: for, while и do...while", "if (i != 5)", "prototype", "Выводит окно", "5555", "Нет такого оператора.", "parent", "да" , "Зависит от движка браузера" };
    private static string[] rightAnswersJava = { "Элементы в коллекции упорядочены.", "Может быть объявлен как finalabstract.", "Если switch блока нет default, считается подходящим добавление assert default.", "Да, можно", "не ограничена", "public static void main(String ... args)", "Сравнивает объекты", "Модификатор доступа — private. Доступ через методы get, set.", "Используется для обращения к текущему классу", "Используется для обращения к базовому классу", "Создание, активация, подготовка к работе, определение параметров. ", "Примитивные и ссылочные", "Это одноразовое выполнение кода, размещенного в теле цикла.", "Преобразование из примитивных типов данных к ссылочным и наоборот.", "break" , "Элементы в коллекции упорядочены."};
    private static string[] rightAnswersSharp = { "int[] arr = new int [2] {2, 5};", "Работает с исключениями", "String.Compare (”hi”, ”hello”);", "++", "--", "char symbol = 'A';", "2", "true", "Continue пропускает итерацию, break выходит из цикла",  "||", "тернарный", "0", "Если строка часто изменяется","int[] arr = new int [2] {2, 5};", "Работает с исключениями","3" };

    public static string[] GetQuestion(string category)
    {
        switch (category)
        {
            case "C++":
                return questionsC;
            case "Java":
                return questionsJava;
            case "C#":
                return questionsSharp;
            case "Javascript":
                return questionsJavaScript;
            default:
                return null;
        }
    }

    public static string[][] GetAnswers(string category)
    {
        switch (category)
        {
            case "C++":
                return answersC;
            case "Java":
                return answersJava;
            case "C#":
                return answersSharp;
            case "Javascript":
                return answersJavaScript;
            default:
                return null;
        }
    }

    public static string[] GetRightAnswer(string category)
    {
        switch (category)
        {
            case "C++":
                return rightAnswersC;
            case "Java":
                return rightAnswersJava;
            case "C#":
                return rightAnswersSharp;
            case "Javascript":
                return rigthAnswersJavaScript;
            default:
                return null;
        }
    }

}
