using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Step
    {
        public string Question;
        public string[] Answers;
        public bool HasAnswer;

        public Step(string question, string[] answers)
        {
            Question = question;
            Answers = answers;
        }
    }

    class Form
    {
        public Step[] Steps;

        public Form(Step[] steps)
        {
            Steps = steps;
        }

        public void ReadAllAnswers()
        {
            foreach (var step in Steps)
            {
                Console.WriteLine(step.Question);
                for (int i = 0; i < step.Answers.Length; i++)
                {
                    Console.WriteLine("[{0}]>{1}", i, step.Answers[i]);
                }
                Console.ReadLine();
                step.HasAnswer = true;
            }
        }
    }
    
    class Temp
    {
        public static void Do()
        {
            Form form = new Form(new Step[]
            {
                new Step("Кто вы?", new string[] { "Человек", "Брандлмуха", "Кхаджит" }),
                new Step("Что вы хотите?", new string[] { "Победить Аразота", "Стать богатым", "Найти боевых товарищей" }),
                new Step("Чем вы можете помочь ордену?", new string[] { "Я отлчиный воин", "Я добротный маг", "Я могу работать в кузнице" })
            });

            Console.WriteLine("Совершенно очевидно, что мы не берём в наш орден кого попало. По этому заполни вот эту анкету, " +
                              "и мы примем решение, брать тебя или нет");

            form.ReadAllAnswers();
        }
    }
}
