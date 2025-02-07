public class Solution
{
    public bool DetectCapitalUse(string word)
    {
        /*
            Defini que todos s�o true/verdadeiro.
            allUpperCase, significa que todas as letras s�o  mai�sculas.
            allLowerCase, significa que todos as letras s�o min�sculas.
            justFirstUpper, significa que apenas a primeira � mai�scula.
        */
        bool allUpperCase = true, allLowerCase = true, justFirstUpper = true;


        /*
            Neste for, fiz um loop que vai at� o ultimo elemento da string/palavra,verificando se s�o todas  mai�sculas,
            todas min�sculas ou apenas primeira letra � mai�scula.
        */
        for (int i = 0; i < word.Length; i++)
        {
            if (!char.IsUpper(word[i])) allUpperCase = false;//se todas n�o forem  mai�sculas retorna false.
            if (!char.IsLower(word[i])) allLowerCase = false;//se todas n�o forem min�sculas retorna false.
            if (i > 0 && char.IsUpper(word[i])) justFirstUpper = false;
            //se ter uma letra mai�scula depois da primeira posi��o, ent�o retorna false por que no Case FlaG n�o � considerado falso.
        }
        //retorna o valor booleano ap�s passar pelo loop
        return allUpperCase || allLowerCase || justFirstUpper;
    }
}