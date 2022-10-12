// Обход разных структур
// ((4-2)*(1+3))/10
// Обход бинарного дерева -> 
// 1. деление 
// 2. умножение
// 3. 10
// 4. вычитание
// 5. сложение
// 6. если бы вместо 10 была операция, то её составляющие были под этим номером
// 7. если бы вместо 10 была операция, то её составляющие были под этим номером
// 8. 4
// 9. 2
// 10. 1
// 11. 3

//a2i <- ai -> a2i+1

string emp = String.Empty;
string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" };
void InOrderTraversal(int pos = 1)
{
    if (pos < tree.Length)
    {
        int left = 2 * pos;
        int right = 2 * pos + 1;
        if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
        Console.WriteLine(tree[pos]);
        if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
        // Если поменять строчки местами, то можно сделать поход по другому принципу

    }
}
InOrderTraversal();
