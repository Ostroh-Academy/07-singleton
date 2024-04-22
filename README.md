24. Розробити Singleton для централізованої системи зв'язку в медичній установі, що включає обмін медичними даними між відділеннями.

## Клас

### HospitalSingleton

Клас `HospitalSingleton` є основним класом проекту, який відповідає за зберігання медичних даних та обмін ними між відділеннями медичної установи. Основні функції цього класу:

- `GetInstance()`: Метод для отримання єдиного екземпляру класу `HospitalSingleton` за допомогою патерну Singleton.
- `AddMedicalData(string data)`: Метод для додавання медичних даних до системи зв'язку.
- `GetMedicalData(int index)`: Метод для отримання медичних даних за індексом.

## UML Діаграма

![UML Diagram](https://github.com/Marian-Zharchynskyi/07-signleton-Marian-Zharchynskyi/blob/main/Lab7UML.png)
