public class Solution
{
    public bool DetectCapitalUse(string word)
    {
        /*
            Defini que todos são true/verdadeiro.
            allUpperCase, significa que todas as letras são  maiúsculas.
            allLowerCase, significa que todos as letras são minúsculas.
            justFirstUpper, significa que apenas a primeira é maiúscula.
        */
        bool allUpperCase = true, allLowerCase = true, justFirstUpper = true;


        /*
            Neste for, fiz um loop que vai até o ultimo elemento da string/palavra,verificando se são todas  maiúsculas,
            todas minúsculas ou apenas primeira letra é maiúscula.
        */
        for (int i = 0; i < word.Length; i++)
        {
            if (!char.IsUpper(word[i])) allUpperCase = false;//se todas não forem  maiúsculas retorna false.
            if (!char.IsLower(word[i])) allLowerCase = false;//se todas não forem minúsculas retorna false.
            if (i > 0 && char.IsUpper(word[i])) justFirstUpper = false;
            //se ter uma letra maiúscula depois da primeira posição, então retorna false por que no Case FlaG não é considerado falso.
        }
        //retorna o valor booleano após passar pelo loop
        return allUpperCase || allLowerCase || justFirstUpper;
    }
}