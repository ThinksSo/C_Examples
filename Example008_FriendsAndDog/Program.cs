int firstFriendSpeed = 4;
int secondFriendSpeed = 5;
int dogSpeed = 20;
double distance = 100;
int distanceLimith = 5;
int dogCounter = 0;
int dogDirection = 1;
double timeToMeet = 0;
int speed = 0;

while (distance > distanceLimith)
{
  if (dogDirection == 1)
  {
    speed = firstFriendSpeed + dogSpeed;
    dogDirection = 0;
    // Console.WriteLine("Change direction to second Friend");
  }
  else
  {
    speed = secondFriendSpeed + dogSpeed;
    dogDirection = 1;
    // Console.WriteLine("Change direction to first Friend");
  }

    timeToMeet = distance / speed;
    distance = distance - timeToMeet * (firstFriendSpeed + secondFriendSpeed);
    dogCounter = dogCounter + 1;
    Console.Write("Distance ");
    Console.WriteLine(distance);
}
Console.WriteLine($"Count: {dogCounter}");
