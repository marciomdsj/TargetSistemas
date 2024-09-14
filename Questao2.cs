/* 2) Escreva um programa que verifique, em uma string, a existência da letra ‘a’, seja maiúscula ou minúscula,
 além de informar a quantidade de vezes em que ela ocorre.*/
using System;
using System.Collections.Generic;
partial class Program
{
    static int CountString(string str)
    {
        int count = 0;
        for(int i = 0;i < str.Length; i++){
            if(str[i] == 'a' || str[i] == 'A') {
                count++;
            }
        }
        return count;
    }

/*-----------------------DESCOMENTE PARA TESTAR-------------------
    static void Main(string[] args){
        bool contem = false;
        string str = "TESTA";
        for(int i = 0; i < str.Length; i++){
            if(str[i] == 'A' || str[i] == 'a') {contem = true;}
        }
        if(contem){
            Console.WriteLine("True " + CountString(str));
        }
        else{
            Console.WriteLine("False");
        }

    }
    */
}
