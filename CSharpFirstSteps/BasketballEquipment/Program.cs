int annualFee = int.Parse(Console.ReadLine());

double basketballSneakers = annualFee - (annualFee * 0.40);
double basketballSportsSuit = basketballSneakers - (basketballSneakers * 0.20);
double basketBall = basketballSportsSuit * 1 / 4;
double basketballAccessories = basketBall * 1 / 5;

double totalPrice = basketballSneakers + basketballSportsSuit + basketBall + basketballAccessories + annualFee;

Console.WriteLine(totalPrice);  