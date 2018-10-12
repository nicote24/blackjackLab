using System;
using System.Threading;
//enum
enum sorte { Coeur = 1, Pique = 2, Carreau = 3, trefle = 4 }

namespace labs_2_black_jack_VRAI
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.SetWindowSize(180, 60);

            //variables

            int jetons = 100;
            int carte1 = 0;
            int carte2 = 0;
            int valeurCarte = 0;
            int carteint1 = 0;
            int jetonsmise = 0;
            int choix1 = 0;
            int carteint2 = 0;
            int carte3 = 0;
            int resultatjoueur = 0;
            int resultatInt = 0;
            int carteint3 = 0;
            sorte couleurcarte2int = 0;
            sorte couleurcarte = 0;
            int chiffrecarte2int = 0;
            bool finboucle = true;
            string fin = "";
            string debut = "";

            //fonction cartex2
            sorte carteRam()
            {
                Random aleatoire = new Random();
                couleurcarte = (sorte)aleatoire.Next(1, 5);
                return couleurcarte;
            }
            void couleur(sorte couleurtest)
            {
                if (couleurtest == sorte.Coeur)
                {

                    Console.WriteLine("de Coeur");

                }
                else if (couleurtest == sorte.Pique)
                {

                    Console.WriteLine("de Pique");
                }
                else if (couleurtest == sorte.Carreau)
                {

                    Console.WriteLine("de Carreau");
                }
                else if (couleurtest == sorte.trefle)
                {

                    Console.WriteLine("de Trèfle");
                }

            }

            //fonction chiffre

            int ChiffreRam()
            {
                int nbcarte = 0;
                Random aleatoire1 = new Random();
                nbcarte = aleatoire1.Next(1, 14);
                return nbcarte;
            }
            void chiffrecarte(int carte0)
            {
                switch (carte0)
                {

                    case 1: Console.WriteLine("as"); valeurCarte = 11; break;
                    case 2: Console.WriteLine("deux"); valeurCarte = 2; break;
                    case 3: Console.WriteLine("trois"); valeurCarte = 3; break;
                    case 4: Console.WriteLine("quatre"); valeurCarte = 4; break;
                    case 5: Console.WriteLine("cinq"); valeurCarte = 5; break;
                    case 6: Console.WriteLine("six"); valeurCarte = 6; break;
                    case 7: Console.WriteLine("sept"); valeurCarte = 7; break;
                    case 8: Console.WriteLine("huit"); valeurCarte = 8; break;
                    case 9: Console.WriteLine("neuf"); valeurCarte = 9; break;
                    case 10: Console.WriteLine("dix"); valeurCarte = 10; break;
                    case 11: Console.WriteLine("valet"); valeurCarte = 10; break;
                    case 12: Console.WriteLine("dame"); valeurCarte = 10; break;
                    case 13: Console.WriteLine("roi"); valeurCarte = 10; break;

                }

            }
            void afficherImage()
            {
                Console.WriteLine("B)bbbb   l)L                  k)        J)jjjjjj                 k)        P)ppppp  R)rrrrr   O)oooo    G)gggg R)rrrrr    A)aa    M)mm mmm   M)mm mmm  E)eeeeee");
                Console.WriteLine("B)   bb   l)                  k)            J)                   k)        P)    pp R)    rr O)    oo  G)      R)    rr  A)  aa  M)  mm  mm M)  mm  mm E)      ");
                Console.WriteLine("B)bbbb    l)  a)AAAA   c)CCCC k)  KK        J)   a)AAAA   c)CCCC k)  KK    P)ppppp  R)  rrr  O)    oo G)  ggg  R)  rrr  A)    aa M)  mm  mm M)  mm  mm E)eeeee ");
                Console.WriteLine("B)   bb   l)   a)AAA  c)      k)KK      J)  jj    a)AAA  c)      k)KK      P)       R) rr    O)    oo G)    gg R) rr    A)aaaaaa M)  mm  mm M)  mm  mm E)      ");
                Console.WriteLine("B)    bb  l)  a)   A  c)      k) KK     J)  jj   a)   A  c)      k) KK     P)       R)   rr  O)    oo  G)   gg R)   rr  A)    aa M)      mm M)      mm E)      ");
                Console.WriteLine("B)bbbbb  l)LL  a)AAAA  c)CCCC k)  KK     J)jj     a)AAAA  c)CCCC k)  KK    P)       R)    rr  O)oooo    G)ggg  R)    rr A)    aa M)      mm M)      mm E)eeeeee");
            }
            void calculsWin()
            {
                //affichage carrte 2 IA
                Thread.Sleep(500);
                Console.WriteLine("");
                Console.WriteLine("la deuxème carte de votre adversaire était le");
                Thread.Sleep(3000);
                Console.WriteLine("");
                chiffrecarte(chiffrecarte2int);
                couleur(couleurcarte2int);
                carteint2 = valeurCarte;
                //Resultat Joueur

                resultatjoueur = carte1 + carte2 + carte3;
                //Resultat IA

                resultatInt = carteint1 + carteint2;
                //Calcul de l'IA

                if (resultatjoueur > resultatInt && resultatjoueur <= 21)
                {


                    //Afficahge carte 3 ia
                    Thread.Sleep(1000);
                    Console.WriteLine("");
                    Console.WriteLine("votre adversaire pige alors une troisème carte qui est le: ");
                    Thread.Sleep(3000);
                    Console.WriteLine("");
                    chiffrecarte(ChiffreRam());
                    Console.WriteLine("De");

                    couleur(carteRam());

                    carteint3 = valeurCarte;
                    //Resultat IA

                    resultatInt = carteint1 + carteint2 + carteint3;

                    //résultat affichage
                    Thread.Sleep(800);
                    Console.WriteLine("");
                    Console.WriteLine("vous avez donc un résultat total de " + resultatjoueur + " et le résultat de votre adversaire est de " + resultatInt);
                    Console.WriteLine("");
                    if (resultatInt < resultatjoueur && resultatjoueur <= 21 || resultatInt > 21)
                    {
                        Thread.Sleep(500);
                        Console.WriteLine("vous avez gagné");
                        Console.WriteLine("");
                        Thread.Sleep(500);
                        Console.WriteLine("vous gagnez donc: " + jetonsmise + " et vous retrouvez donc avec un total de " + (jetons = jetons + jetonsmise) + " jetons");
                        Console.WriteLine("");
                        Thread.Sleep(500);
                        Console.WriteLine("apuuyez sur un touche pour continuer");
                        Console.ReadKey();
                        Console.Clear();

                    }
                    else if (resultatInt > resultatjoueur && resultatInt <= 21 || resultatjoueur > 21)
                    {
                        Thread.Sleep(800);
                        Console.WriteLine("vous avez perdu");
                        Console.WriteLine("");
                        Thread.Sleep(500);
                        Console.WriteLine("vous perdez donc: " + jetonsmise + " et vous retrouvez donc avec un total de " + (jetons = jetons - jetonsmise) + " jetons");
                        Console.WriteLine("");
                        Thread.Sleep(500);
                        Console.WriteLine("apuuyez sur un touche pour continuer");
                        Console.ReadKey();
                        Console.Clear();
                    }




                    else
                    {
                        Thread.Sleep(800);
                        Console.WriteLine("vous avez tout deux surpasser le nombre maximal de 21, ou vous avez fait une egalité, vous gardez votre mise");
                        Console.WriteLine("");
                        Thread.Sleep(500);
                        Console.WriteLine("apuuyez sur un touche pour continuer");
                        Console.ReadKey();
                        Console.Clear();

                    }
                }
                else
                {
                    Thread.Sleep(900);
                    Console.WriteLine("vous avez donc un résultat total de " + resultatjoueur + " et le résultat de votre adversaire est de " + resultatInt);
                    Console.WriteLine("");
                    if (resultatInt < resultatjoueur && resultatjoueur <= 21 || resultatInt > 21)
                    {
                        Thread.Sleep(500);
                        Console.WriteLine("vous avez gagné");
                        Console.WriteLine("");
                        Thread.Sleep(500);
                        Console.WriteLine("vous gagnez donc: " + jetonsmise + " et vous retrouvez donc avec un total de " + (jetons = jetons + jetonsmise) + " jetons");
                        Thread.Sleep(500);
                        Console.WriteLine("");
                        Console.WriteLine("apuuyez sur un touche pour continuer");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if (resultatInt > resultatjoueur && resultatInt <= 21 || resultatjoueur > 21)
                    {
                        Thread.Sleep(500);
                        Console.WriteLine("vous avez perdu");
                        Console.WriteLine("");
                        Thread.Sleep(500);
                        Console.WriteLine("vous perdez donc: " + jetonsmise + " et vous retrouvez donc avec un total de " + (jetons = jetons - jetonsmise) + " jetons");
                        Console.WriteLine("");
                        Thread.Sleep(500);
                        Console.WriteLine("apuuyez sur un touche pour continuer");
                        Console.ReadKey();
                        Console.Clear();
                    }

                    else
                    {
                        Thread.Sleep(500);
                        Console.WriteLine(" vous avez fait une egalité, vous gardez votre mise");
                        Console.WriteLine("");
                        Thread.Sleep(500);
                        Console.WriteLine("apuuyez sur un touche pour continuer");
                        Console.ReadKey();
                        Console.Clear();

                    }
                }
            }
            //DEBUT DU PROGRAMME
            afficherImage();
            Console.WriteLine("");
            Console.WriteLine("bienvenue sur ¸le programme d'adversité blackjack, le but est d'Avoir le plus près possible de 21 ! pour commencer cliquer sur nimporte quel touche !");
            Console.WriteLine("");
            debut = Console.ReadLine();
            while (finboucle)
            {
                Console.WriteLine("vous avez maintenant " + jetons + " jetons");
                Console.WriteLine("");
                Console.WriteLine("Si vous voulez vous retirez, ecrivez ( fini ), si non appuyez sur n'importe quel touche)");
                fin = Console.ReadLine();

                if (fin == "fini" || jetons <= 0)
                {
                    Thread.Sleep(800);
                    Console.WriteLine("");
                    afficherImage();
                    Console.WriteLine("");
                    Console.WriteLine("vous n'avez plus de jetons ou vous avez decidé de vous retirez , aurevoir !");
                    Console.ReadKey();
                    finboucle = false;
                }
                else
                {

                    Console.WriteLine("Veuillez misez un certain nombre de vos jetons :");
                    jetonsmise = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");
                    Thread.Sleep(1000);
                    Console.WriteLine("vous misez alors " + jetonsmise + " et ils vous reste donc " + (jetons - jetonsmise) + " jetons");
                    Console.WriteLine("");
                    if (jetonsmise <= jetons)
                    {
                        Thread.Sleep(1000);
                        Console.WriteLine("vous pigez les 2 cartes ci-dessous");
                        Console.WriteLine("");
                        chiffrecarte(ChiffreRam());
                        Console.WriteLine("De");
                        couleur(carteRam());
                        carte1 = valeurCarte;
                        Console.WriteLine("");
                        Thread.Sleep(3000);
                        Console.WriteLine("et le ");
                        Console.WriteLine("");
                        chiffrecarte(ChiffreRam());
                        Console.WriteLine("De");
                        couleur(carteRam());
                        carte2 = valeurCarte;
                        Console.WriteLine("");
                        Thread.Sleep(1000);

                        //----------------------------------------------------------------------------
                        Console.WriteLine("--------------------------------------");
                        Console.WriteLine("");
                        Console.WriteLine("L'une des carte que votre adversaire à pigeé est le :");
                        Thread.Sleep(3000);
                        Console.WriteLine("");
                        Console.WriteLine("");
                        chiffrecarte(ChiffreRam());
                        Console.WriteLine("De");

                        couleur(carteRam());
                        carteint1 = valeurCarte;
                        Thread.Sleep(1500);
                        //-----------------------------------------------------------------------------

                        carteRam();
                        chiffrecarte2int = ChiffreRam();
                        couleurcarte2int = carteRam();

                        if (carte1 + carte2 == 21)
                        {
                            Console.WriteLine("BLAKCJACK vous avez atteint la valeur maximal en 2 carte , a moin que votre adversaire en ai un aussi, vous gagerez le double de votre mise");
                            Console.WriteLine("");
                            Thread.Sleep(2500);
                            Console.WriteLine("la deuxème carte de votre adversaire était le");
                            Console.WriteLine("");
                            chiffrecarte(chiffrecarte2int);
                            couleur(couleurcarte2int);
                            carteint2 = valeurCarte;
                            if (carteint1 + carteint2 == 21)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("vous êtes en égalité , vous gardez donc seulement votre mise");
                                Console.WriteLine("");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine("");
                                Console.WriteLine("GAGNÉ");
                                Console.WriteLine("vous gagnez donc: " + jetonsmise * 2 + "et vous retrouvez donc avec un total de " + (jetons = (jetonsmise * 2) + jetons) + " jetons");
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("si vous voulez repiger un carte, (appuyez sur 1) ");
                            Console.WriteLine("vous gardez vos 2 cartes (appuyez sur 2) ");
                            choix1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("");
                            if (choix1 == 1)
                            {
                                Thread.Sleep(2500);
                                Console.WriteLine("vous pigez le:");
                                Console.WriteLine("");
                                chiffrecarte(ChiffreRam());
                                Console.WriteLine("De");

                                couleur(carteRam());
                                carte3 = valeurCarte;
                                Thread.Sleep(2500);
                                calculsWin();
                            }
                            else if (choix1 == 2)
                            {
                                carte3 = 0;
                                Thread.Sleep(2500);
                                calculsWin();
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("petit IDIOT tu à essayer d'arnaquer le systeme ! tu as miser plus de jetons que tu n'en possède, recommence!");
                    }
                }
            }
        }
    }
}