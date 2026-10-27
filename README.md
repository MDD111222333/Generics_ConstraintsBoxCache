# C_Sharp_Generics_ConstraintsBoxCache

## C#_Generics_ConstraintsBoxCache

### Задание «Контрольная точка №26 — ограничения ссылочного типа и типа значения»

Задание 1. Обёртки
1. ReferenceBox<T> where T : class с методами Set(T item), bool IsEmpty, T? Get(), использующий null как «пустое» состояние.
2. ValueBox<T> where T : struct с тем же набором методов, использующий Nullable<T> (T?) как «пустое» состояние.
3. Продемонстрируйте ReferenceBox<string> (или своим классом): пустое и заполненное состояние.
4. Продемонстрируйте ValueBox<int> (или своей структурой): пустое и заполненное состояние.
5. Продемонстрируйте (закомментированным кодом с пояснением), что ReferenceBox<int> и ValueBox<string> не компилируются.

Задание 2. Кэш
1. ReferenceCache<T> where T : class с методом bool TryGet(out T? value), возвращающим false и null, если кэш пуст, и true с сохранённым значением — иначе.
2. ValueCache<T> where T : struct с тем же по смыслу методом bool TryGet(out T? value), использующим Nullable<T> внутри для представления «пусто».
3. Продемонстрируйте ReferenceCache<string> (или своим классом): попадание и промах кэша.
4. Продемонстрируйте ValueCache<double> (или своей структурой): попадание и промах кэша.
5. Продемонстрируйте (закомментированным кодом с пояснением), что ReferenceCache<double> и ValueCache<string> не компилируются.

Результаты и проверочные ключи:

<img width="1809" height="405" alt="изображение" src="https://github.com/user-attachments/assets/3d7e2aa6-ba18-4860-a705-232f54dd367e" />


Результат работы:

<img width="1611" height="555" alt="изображение" src="https://github.com/user-attachments/assets/fba5d890-c159-4275-9f7f-304cb80ec7de" />
