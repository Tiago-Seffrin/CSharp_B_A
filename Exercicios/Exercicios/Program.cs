using System;
using System.Collections.Generic;
using Exercicios.Fundamentos;
using Exercicios.Classes;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                //-------Lógica de programação-------------------------//
                {"Primeiro Programa - Fundamentos", Exercicio1.Executar},
                {"Segundo Programa - Fundamentos", Exercicio2.Executar},
                {"Terceiro Programa - Fundamentos", Exercicio3.Executar},
                {"Quarto Programa - Fundamentos", Exercicio4.Executar},
                {"Quinto Programa - Fundamentos", Exercicio5.Executar},
                {"Sexto Programa - Fundamentos", Exercicio6.Executar},
                {"Sétimo Programa - Fundamentos", Exercicio7.Executar},
                {"Oitavo Programa - Fundamentos", Exercicio8.Executar},
                {"Nono Programa - Fundamentos", Exercicio9.Executar},
                {"Décimo Programa - Fundamentos", Exercicio10.Executar},
                {"Décimo primeiro Programa - Fundamentos", Exercicio11.Executar},
                {"Décimo segundo Programa - Fundamentos", Exercicio12.Executar},
                {"Décimo terceiro Programa - Fundamentos", Exercicio13.Executar},
                {"Décimo Quarto Programa - Fundamentos", Exercicio14.Executar},
                {"Décimo Quinto Programa - Fundamentos", Exercicio15.Executar},
                {"Décimo Sexto Programa - Fundamentos", Exercicio16.Executar},
                {"Décimo Sétimo Programa - Fundamentos", Exercicio17.Executar},
                {"Décimo Oitavo Programa - Fundamentos", Exercicio18.Executar},
                //------Classes, Atributos, métodos e membros estáticos--------//
                {"Primeiro Programa - Classes", Exercicio19.Executar},


            });

            central.SelecionarEExecutar();
        }
    }
}