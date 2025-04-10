using System;
using System.Collections.Generic;

using Exercicios.Fundamentos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", Exercicio1.Executar},
                {"Segundo Programa - Fundamentos", Exercicio2.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}