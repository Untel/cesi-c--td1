using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TestApp {

    class Program {

        static void Main(string[] args) {

            while(true)
            {
                Console.Write("Choisissez un exercice à executer : ");
                int res = Int32.Parse(Console.ReadLine());
                Console.WriteLine();

                switch(res) {
                    case 1:
                        /**
                         * 1. Code C# calculant de la surface et le volume d’une sphere
                         */
                        Console.WriteLine(Program.computeSphere(7.5));
                        break;

                    case 2:
                        /**
                          * 2. Code C# produisant les outputs suivants :
                          * x value   y value    expression     result
                          * 10         5                x=y+3          x=8
                          * 10         5                x=y-2           x=3
                          * 10         5                x=y*5          x=25
                          * 10         5                x=x/y           x=2
                          * 10         5                x=x%y         x=0
                          */
                        Program.showOutputs();
                        break;

                    case 3:
                        /**
                         * 3. Code C# servant à calculer la valeur absolue d’un nombre réel x à partir de la définition de la valeur absolue.
                         */
                        Program.realNumber(-50);
                        break;

                    case 4:
                        /**
                         * Code C# promptant à l’utilisateur 3 valeurs entière et qui trouve la valeur la plus grande.
                         */
                        Program.maxOfThreeValues();
                        break;

                    case 5:
                        /**
                         * 5. Code C# promptant à l’utilisateur 2 valeurs entière et effectuant la division du premier par le second nombre.
                         */
                        Program.divideTwoValues();
                        break;

                    case 6:
                        /**
                         * 6. Code C# demandant la saisie de deux entiers et l’opération (élémentaire) sur les deux nombres
                         */
                        Program.twoValuesAndOperator();
                        break;

                    case 7:
                        /**
                         * 7. Code C# demandant la saisie de deux flotants et l’opération (élémentaire) sur les deux nombres.
                         */
                        Program.twoFloatValuesAndOperator();
                        break;

                    case 8:
                        /**
                         * 8. Code C# de la résolution d’une équation du second degrès.
                         */
                        Program.secondDegreeEquation(36, -36, 5);
                        break;

                    case 9:
                        /**
                         * 9. Code C# calculant la moyenne pondérée de la série suivant et mettant en relation les mentions suivantes :
                         *      2.4 ; 3.7 ; 2.5 ; 5.6 ; 4.5 ; 5 ; 4 ; 5.8 ; 6 
                         *      6	Excellent
                         *      5	Bien
                         *      4	Suffisant
                         *      3	Médiocre
                         *      2	Très mauvais
                         *      1	Prestation nulle
                         */
                        Program.average(new double[] { 2.4, 3.7, 2.5, 5.6, 4.5, 5, 4, 5.8, 6 });
                        break;

                    case 10:
                        /**
                         * 10. Code C# demandant la saisie d’un nombre entier et réalisant l’affichage de la table de multiplication.
                         */
                        Program.multiplyTable();
                        break;

                    case 11:
                        /**
                         * 11. Code C# réalisant l’output
                         *   *******
                         *   ******
                         *   *****
                         *   ****
                         *   ***
                         *   **
                         *   *
                         */
                        Program.asterisk();
                        break;

                    case 12:
                        /**
                         * 12. Code C# réalisant le pattern suivant
                         *   1******
                         *   12*****
                         *   123****
                         *   1234***
                         *   12345**
                         *   123456*
                         *   1234567
                         */
                        Program.asteriskFromPattern();
                        break;

                    case 13:
                        /**
                         * 13. Code C# réalisant le jeu du pendu.
                         */
                        Program.countValues();
                        break;

                    case 14:
                        /**
                         * 14. Code C# réalisant le jeu du pendu.
                         */
                        Program.pendu("helloworld");
                        break;

                    case 15:
                        /**
                         * 15. Code C# simulant le jeu du loto
                         */
                        Program.loto();
                        break;

                    case 16:
                        /**
                         * 16. Code C# réalisant l’invite de commande pour rentrer le login password d’un utilisateur.
                         */
                        Program.login();
                        break;

                    case 17:
                        /**
                         * 17. Code C# réalisant la somme de deux entiers, de deux flottants
                         */
                        Console.WriteLine(Sum(1, 2));
                        Console.WriteLine(Sum(1.2, 2.1));
                        break;

                    case 18:
                        /**
                         * 18. Code C# demandant la saisie d’une longueur et d’une largeur d'un rectangle. 
                         */
                        Console.Write("Saisissez une longueur : ");
                        double l = Double.Parse(Console.ReadLine());

                        Console.Write("Saisissez une largeur : ");
                        double L = Double.Parse(Console.ReadLine());

                        Console.WriteLine(String.Concat("La surface de votre triangle est : ", CalculSurfaceRectangle(l, L)));
                        break;

                    case 19:
                        /**
                         * 19. Code C# comptant les espaces dans une chaine de caractère.
                         */
                        Console.WriteLine(countSpaces("Il y a  5 espaces"));
                        break;

                    case 20:
                        /**
                         * 20. Code C# demandant la saisie d’une chaine de caractère et effectuant les manipulations suivantes 
                         */
                        Console.Write("Chaine à formatter : ");
                        Console.WriteLine("\n Votre variable formatée est " + FormatVariable(Console.ReadLine()));
                        break;

                    case 666:
                        Program.music();
                        break;

                    case 999:
                        Program.peoples();
                        break;

                    default:
                        break;

                }

                Console.WriteLine();
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine();

            }
        }

        /**
          * 1. Code C# calculant de la surface et le volume d’une sphere
          */
        static double computeSphere(double radian)
        {
            return 4 * Math.PI * Math.Pow(radian, 2);
        }

        /**
          * 2. Code C# produisant les outputs suivants :
          * x value   y value    expression     result
          * 10         5                x=y+3          x=8
          * 10         5                x=y-2           x=3
          * 10         5                x=y*5          x=25
          * 10         5                x=x/y           x=2
          * 10         5                x=x%y         x=0
          */

        static void showOutputs()
        {
            Console.WriteLine("x value   y value    expression     result");
            Console.WriteLine("   10         5         x=y+3        x=8");
            Console.WriteLine("   10         5         x=y-2        x=3");
            Console.WriteLine("   10         5         x=y*5        x=25");
            Console.WriteLine("   10         5         x=x/y        x=2");
            Console.WriteLine("   10         5         x=x%y        x=0");
            return;
        }

        /**
         * 3. Code C# servant à calculer la valeur absolue d’un nombre réel x à partir de la définition de la valeur absolue.
         */
        static void realNumber(int nb)
        {
            int x = nb;
            if (nb < 0)
            {
                x = -nb;
            }

            Console.WriteLine("La valeur absolue du nombre reel " + nb + " est le nombre reel " + x + ".");
        }


        /**
         * 4. Code C# promptant à l’utilisateur 3 valeurs entière et qui trouve la valeur la plus grande.
         */
        static void maxOfThreeValues()
        {
            int max = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Choisissez une valeure");
                int val = Int32.Parse(Console.ReadLine());
                if (val > max)
                {
                    max = val;
                }
            }
            Console.WriteLine("La valeure maximale saisie est " + max);
        }


        /**
         * 5. Code C# promptant à l’utilisateur 2 valeurs entière et effectuant la division du premier par le second nombre.
         */
        static void divideTwoValues()
        {
            Console.Write("Veuillez inserer la premiere valeure de la division : ");
            int x = Int32.Parse(Console.ReadLine());
            Console.Write("Veuillez inserer la seconde valeure de la division : ");
            int y = Int32.Parse(Console.ReadLine());

            Console.Write("Le resultat de la division de " + x + " par " + y + " est " + (x / y));
            return;
        }

        /**
         * 6. Code C# demandant la saisie de deux entiers et l’opération (élémentaire) sur les deux nombres
         */
        static void twoValuesAndOperator()
        {
            Console.Write("Veuillez insérer un premier entier : ");
            int x = Int32.Parse(Console.ReadLine());

            Console.Write("Veuillez sélectionner l'opérateur de l'opération ");
            char o = Char.Parse(Console.ReadLine());

            Console.Write("Veuillez insérer un second entier: ");
            int y = Int32.Parse(Console.ReadLine());

            double res;
            string operate;
            switch (o)
            {
                case 'x':
                case '*':
                    operate = "la multiplication";
                    res = (x * y);
                    break;

                case '+':
                    operate = "l'addition";
                    res = (x + y);
                    break;

                case '-':
                    operate = "la soustraction";
                    res = (x - y);

                    break;

                case '/':
                case '÷':
                default:
                    operate = "la division";
                    res = (x / y);
                    break;
            }

            Console.Write("Le résultat de " + operate + " de " + x + " et " + y + " vaut " + res);
            return;
        }

        /**
         * 7. Code C# demandant la saisie de deux flotants et l’opération (élémentaire) sur les deux nombres.
         */
        static void twoFloatValuesAndOperator()
        {
            Console.Write("Veuillez insérer un premier décimal : ");
            float x = float.Parse(Console.ReadLine());

            Console.Write("Veuillez l'opérateur de l'opération ");
            char o = Char.Parse(Console.ReadLine());

            Console.Write("Veuillez insérer un second décimal : ");
            float y = float.Parse(Console.ReadLine());

            double res;
            string operate;
            switch (o)
            {
                case 'x':
                case '*':
                    operate = "la multiplication";
                    res = (x * y);
                    break;

                case '+':
                    operate = "l'addition";
                    res = (x + y);
                    break;

                case '-':
                    operate = "la soustraction";
                    res = (x - y);

                    break;

                case '/':
                default:
                    operate = "la division";
                    res = (x / y);
                    break;
            }

            Console.Write("Le résultat de " + operate + " de " + x + " et " + y + " vaut " + res);
            return;
        }

        /**
        * 8. Code C# de la résolution d’une équation du second degrès.
        */

        static void secondDegreeEquation(int a, int b, int c)
        {
            double d = Math.Pow(b, 2) - (4 * a * c);

            if (d > 0)
            {
                double x1 = (-b - Math.Sqrt(d)) / (2 * a);
                double x2 = (-b + Math.Sqrt(d)) / (2 * a);

                Console.WriteLine("L'equation admet 2 solutions: x1=" + x1 + " et x2=" + x2);
            }
            else if (d == 0)
            {
                double x = -b / (2 * a);

                Console.WriteLine("L'equation n'admet qu'une solution: x=" + x);
            }
            else
            {

                Console.WriteLine("L'equation n'admet aucune solution");
            }

        }

        /**
         * 9. Code C# calculant la moyenne pondérée de la série suivant et mettant en relation les mentions suivantes :
         *      2.4 ; 3.7 ; 2.5 ; 5.6 ; 4.5 ; 5 ; 4 ; 5.8 ; 6 
         *      6	Excellent
         *      5	Bien
         *      4	Suffisant
         *      3	Médiocre
         *      2	Très mauvais
         *      1	Prestation nulle
         */
        static void average(double[] notes)
        {
            string[] mention = new string[6] { "Excellent", "Bien", "Suffisant", "Médiocre", "Très mauvais", "Prestation nulle" };

            int avg = (int)Math.Ceiling(notes.Average());
            Console.WriteLine("La moyenne des notes est " + avg + " : " + mention[mention.Length - avg] + " !");
        }

        /**
         * 10. Code C# demandant la saisie d’un nombre entier et réalisant l’affichage de la table de multiplication.
         */
        static void multiplyTable()
        {
            Console.WriteLine("Saisissez un nom entier afin d'afficher sa table de multiplication");
            int number = Int32.Parse(Console.ReadLine());

            Console.WriteLine("La table de " + number + " est: ");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(number + "x" + i + "=" + (number * i));
            }
        }

        /**
         * 11. Code C# réalisant l’output
         *   *******
         *   ******
         *   *****
         *   ****
         *   ***
         *   **
         *   *
         */
        static void asterisk()
        {
            for (int i = 7; i > 0; i--)
            {
                Console.WriteLine(new String('*', i));
            }
        }

        /**
         * 12. Code C# réalisant le pattern suivant
         *   1******
         *   12*****
         *   123****
         *   1234***
         *   12345**
         *   123456*
         *   1234567
         */
        static void asteriskFromPattern()
        {
            int max = 7;
            for (int i = 1; i <= max; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine(i + new String('*', max - i));
            }
        }

        /**
         * 13. Code C# demandant la saisie de 10 entiers et réalisant le comptage de valeurs positives et de valeurs nagatives.
         */
        static void countValues()
        {
            int neg = 0;
            int pos = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Saisissez une valeur : ");
                int val = Int32.Parse(Console.ReadLine());
                if (val < 0)
                {
                    neg++;
                }
                else
                {
                    pos++;
                }
            }

            Console.WriteLine("Vous avez saisi " + neg + " valeurs négatives et " + pos + " valeurs positives");
        }

        /**
         * 14. Code C# réalisant le jeu du pendu.
         */
        static void pendu(string word)
        {

            if (word == null || word.Length == 0) word = "helloworld";

            int nbError = 10;
            char[] cryptedWord = Enumerable.Repeat('_', word.Length).ToArray();
            bool win = false;
            int i = 0;

            // J'utilise plutôt un while pour incrémenter i que si la réponse est erroné, 
            // plutôt que devoir décrémenter si bonne réponse avec un for, et devoir break; si le joueur a gagné avant la fin.
            while (i < nbError && win == false)
            {

                Console.WriteLine("Veuillez saisir une lettre ou un mot");
                string input = Console.ReadLine().ToLower();

                if (input.Length == 1)
                {
                    char letter = Char.Parse(input);

                    int foundIndex = word.IndexOf(letter);
                    if (foundIndex != -1)
                    {

                        // cryptedWord[foundIndex] = letter;
                        for (int j = 0; j < word.Length; j++)
                        {
                            if (word[j].Equals(letter))
                            {
                                cryptedWord[j] = letter;
                            }
                        }

                        if (String.Join("", cryptedWord).Equals(word))
                        {
                            win = true;
                            break;
                        }
                    }
                    else
                    {
                        i++;
                    }

                }
                else
                {
                    if (input.Equals(word))
                    {
                        win = true;
                        break;
                    }
                    else
                    {
                        i++;
                    }
                }
                Console.WriteLine("Mot : " + String.Join("", cryptedWord));
                Console.WriteLine("Il vous reste " + (nbError - i) + " essais");
            }

            if (win == true)
            {
                Console.WriteLine("Bravo! Vous avez trouvé le mot " + word + " :)");
            }
            else
            {
                Console.WriteLine("Dommage, vous n'avez pas trouvé le mot " + word + " :(");
            }

        }

        /**
         * 15. Code C# simulant le jeu du loto
         */
        static void loto()
        {
            int nb = 6;
            //int[] number = new int[6];
            List<int> number = new List<int>();

            while (nb - number.Count != 0)
            {
                Console.Write(String.Concat("Veuillez saisir ", nb - number.Count(), " numéros : "));
                string[] input = Console.ReadLine().Split(' ');
                for (int i = 0; i < input.Length; i++)
                {
                    int num = Int32.Parse(input[i]);
                    if (!number.Contains(num) && num > 0 && num <= 50 && (nb - number.Count() > 0))
                    {
                        number.Add(num);
                    }
                }
                Console.WriteLine("Vous avez saisis : " + String.Join(", ", number));
            }

            Console.WriteLine("DEBUT DU LOTO");
            Random rand = new Random();

            List<int> lotoNums = new List<int>();
            int goodNums = 0;
            for (var i = 0; i < nb; i++)
            {
                int actualNum = rand.Next(1, 50);
                if (lotoNums.Contains(actualNum))
                {
                    i--;
                    continue;
                }

                Console.Write("Nous jouons le numéro " + actualNum);

                lotoNums.Add(actualNum);
                if (number.Contains(actualNum))
                {
                    Console.WriteLine(" : Vous avez ce numéro !");
                    goodNums++;
                }
                else
                {
                    Console.WriteLine(" : Vous n'avez pas ce numéro !");
                }
            }

            Console.WriteLine(String.Concat(goodNums, "/", nb, " bons numéros."));
            switch (goodNums)
            {
                case 6:
                    Console.WriteLine("VOUS GAGNEZ LE GROS LOT !");
                    break;

                case 5:
                case 4:
                    Console.WriteLine("Presque au gros lot, pas mal!");
                    break;

                case 3:
                case 2:
                    Console.WriteLine("Pas mal!");
                    break;

                default:
                    Console.WriteLine("Vous aurez plus de chance la prochaine fois!");
                    break;
            }

        }


        /**
         * 16. Code C# réalisant l’invite de commande pour rentrer le login password d’un utilisateur.
         */
        static void login()
        {

            // Mock database
            Dictionary<string, string> users = new Dictionary<string, string>();

            users.Add("adrien", "azerty");
            users.Add("yann", "azertu");
            users.Add("toto", "titi");

            bool loggedIn = false;

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Login : ");
                string login = Console.ReadLine();

                ConsoleKeyInfo key;
                string password = "";

                Console.Write("Password : ");
                do
                {
                    key = Console.ReadKey(true);

                    if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                    {
                        password += key.KeyChar;
                        Console.Write("*");
                    }
                    else
                    {
                        if (key.Key == ConsoleKey.Backspace && password.Length > 0)
                        {
                            password = password.Substring(0, (password.Length - 1));
                            Console.Write("\b \b");
                        }
                    }
                } while (key.Key != ConsoleKey.Enter);
                Console.WriteLine();

                try
                {
                    string pwdToCompare;
                    users.TryGetValue(login, out pwdToCompare);

                    if (pwdToCompare.Equals(password))
                    {
                        loggedIn = true;
                        Console.WriteLine("Vous étes identifié, bienvenue " + login);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Mot de passe incorrect");
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("Cet utilisateur n'éxiste pas.");
                }

            }

            if (!loggedIn)
            {
                Console.WriteLine("Vous vous avez dépassé la limite d'essais.");
                return;
                //throw new Exception("Vous vous avez dépassé la limite d'essais.");
            }

        }


        /**
         * 17. Code C# réalisant la somme de deux entiers, de deux flottants
         */

        static double Sum(double x, double y) {
            return x + y;
        }

        // Surcharge de la fonction Sum
        static int Sum(int x, int y) {
            // On pourrait juste retourner x + y, mais plus générique si le calcul était plus gros.
            return (int)Sum((double)x, (double)y);
        }

        /**
         * 18. Code C# demandant la saisie d’une longueur et d’une largeur d'un rectangle. 
         */
        static double CalculSurfaceRectangle(double l, double L)
        {
            return l * L;
        }

        /**
         * 19. Code C# comptant les espaces dans une chaine de caractère.
         */
        static int countSpaces(string str)
        {
            // return str.Split(' ').Length - 1;
            return str.Count(s => s == ' ');
        }

        /**
         * 20. Code C# demandant la saisie d’une chaine de caractère et effectuant les manipulations suivantes 
         */
        static string FormatVariable(string variable)
        {
            string[] words = variable.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].Substring(0, 1).ToUpper() + words[i].Substring(1);
            }
            return String.Join("_", words);
        }

        static void music () {
            for (; ; )
            {
                Console.WriteLine("Quelle musique voulez vous jouer ?");
                Console.WriteLine("1- Au claire de la lune");
                Console.WriteLine("2- La lettre a Elise");

                string song = Console.ReadLine();

                int octave = Program.chooseOctave();
                int tempo = Program.chooseTempo();

                switch (song) {
                    case "1":
                        Program.beeper("sol. sol. sol. la. si.__ la.__ sol. si. la. la. sol.___", octave, tempo);
                        break;
                    case "2":
                        Program.beeper("mi. re#. mi. re#. mi. re#. si. re. do.__ la. do. mi. la. si. mi.__ sol#. si. do do.___.1", octave, tempo);
                        break;
                    case "3":
                        Program.beeper("re. re._ re._ sol.__ sol.__ la.__ la.__ re.__.1 si._ sol sol si sol mi.__ do.____.1", octave, tempo);
                        break;
                }

                Console.WriteLine("");
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("");

            }
        }

        static int chooseOctave () {
            Console.WriteLine("A quelle octave ?");
            return Int32.Parse(Console.ReadLine());
        }

        static int chooseTempo() {
            Console.WriteLine("A quel tempo ?");
            return Int32.Parse(Console.ReadLine());
        }

        static void beeper (string str, int octave, int tempo) {
            string[] scheme = str.Split(' ');


            for (int i = 0; i < scheme.Length; i++) {

                string[] el = scheme[i].Split('.');

                int len = 1;
                int addoctave = 0;
                if (el.Length > 1) {
                    len = Program.len(el[1]);
                    if (el.Length > 2) {
                        addoctave = Int32.Parse(el[2]);
                        Console.WriteLine("Add " + addoctave);
                    }
                }
                int freq = Program.freq(el[0], octave + addoctave);
                Console.WriteLine("octave " + freq);

                Console.Beep(freq, len * tempo);
            }
                
            // System.Media.SystemSounds.Asterisk.Play();
            // System.Media.SystemSounds.Exclamation.Play();
            // System.Media.SystemSounds.Hand.Play();
        }

        static int freq (string str, int octave) {
            double val;
            switch (str)
            {
                case "si#":
                case "do":
                    val = 65.41;
                    break;

                case "reb":
                case "do#":
                    val = 69.30;
                    break;

                case "re":
                    val = 73.42;
                    break;

                case "mib":
                case "re#":
                    val = 77.78;
                    break;

                case "fab":
                case "mi":
                    val = 82.41;
                    break;

                case "mi#":
                case "fa":
                    val = 87.31;
                    break;

                case "fa#":
                case "solb":
                    val = 92.50;
                    break;

                case "sol":
                    val = 98;
                    break;

                case "sol#":
                case "lab":
                    val = 103.83;
                    break;

                case "la":
                    val = 110;
                    break;

                case "la#":
                case "sib":
                    val = 116.54;
                    break;

                case "si":
                case "dob":
                    val = 123.47;
                    break;
                default:
                    val = Double.Parse(str);
                    break;
            }

            return (int) Math.Round(val * octave);
        }

        static int len(string str)
        {
            if (str.Contains('_')) {
                return (str.Length + 1);
            }
            
            if (str == "" || str == null) {
                return 1;
            }

            return Int32.Parse(str);
        }

        static void peoples () {
            string[] names = new string[7] { "Ange Marie", "Kevin", "Pierrick", "Adrien", "Yann", "Clément", "Max" };
            string[] actions = new string[7] { "love", "fuck", "like", "smell", "rape", "beat", "rekt" };

            int i = names.Length - 1;
            while (i >= 0) {
                string greet = Program.Hello(names[i]);
                Console.WriteLine(greet);
                i--;
            }

            Console.WriteLine("");

            for (; ; ) {
                string[] lovers = Program.whoWithWho(names);
                string action = Program.whichAction(actions);

                string str = String.Concat(lovers[0], " ", action, " ", lovers[1]);
                Console.WriteLine(str);
                Console.ReadLine();
            }
        }

        static String Hello (String name) {
            return String.Concat("Hello ", name, " !");
        }

        static string[] whoWithWho(string[] names) {
            Random rand = new Random();
            int i = (names.Length - 1);
            int i1 = (int) Math.Round(rand.NextDouble() * i);
            int i2 = i1;
            while (i2 == i1) {
                i2 = (int) Math.Round(rand.NextDouble() * i);
            }

            string[] lovers = new string[2] { names[i1], names[i2] };
            return lovers;
        }

        static string whichAction(string[] actions) {
            return actions[ (int) Math.Round(new Random().NextDouble() * (actions.Length - 1)) ];
        }
    }
}
