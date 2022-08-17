class Cities
    {
        public string City_Name { get; set; }
        public int Air_Temperature { get; set; }

        public Cities(string cityname, int airtemperature)
        {
            City_Name = cityname;
            Air_Temperature = airtemperature;
            
        }

        public override string ToString()
        {
            return "(" + City_Name + "," + Air_Temperature + ")";
        }

    }
class Program
        {
            static void Main(string[] args)
            {
string[] cityName = { "Edirne", "İstanbul", "Kırklareli", "Kocaeli", "Denizli", "İzmir", "Manisa", "Muğla", "Adana", "Antalya", "Mersin", "Ankara", "Bolu", "Trabzon", "Erzurum" };

                int[] airTemperature = { 21, 22, 21, 25, 24, 21, 22, 18, 27, 23, 26, 18, 17, 20, 8 };

                ArrayList arrayList = new ArrayList();

                int counter1 = 0;
                int counter2 = 1;
                Cities cities;

                List<Cities> genericList;

                while (counter1 < cityName.Length)
                {
                    genericList = new List<Cities>();
                    int genericListLength = (int)((2 * counter2) - 1);

                    for (int i = 0; i < genericListLength; i++)
                    {
                        cities = new Cities(cityName[counter1], airTemperature[counter1]);
                        genericList.Add(cities);
                        counter1++;

                        if (counter1 == cityName.Length)
                            break;

                    }
                    arrayList.Add(genericList);
                    counter2++;
                }
                foreach (List<Cities> item in arrayList)
                {
                    foreach (Cities item1 in item)
                    {
                        Console.WriteLine("{0}, {1}", item1.City_Name, item1.Air_Temperature);
                    }
                    Console.WriteLine();
                }

class Cities_Stack
    {
        public int maxSize;
        public int[] stackArray;
        public int top;

        public Cities_Stack(int max)
        {
            maxSize = max;
            stackArray = new int[maxSize];
            top = -1;
        }

        public void push(int j)
        {
            stackArray[++top] = j;
        }
        public int pop()
        {
            return stackArray[top--];
        }
        public bool isEmptyStack()
        {
            return top == -1;
        }
    }
Console.WriteLine("The output of the data set --airTemperature-- in Stack form");
                Console.WriteLine();

                Cities_Stack stack = new Cities_Stack(airTemperature.Length);

                for (int i = 0; i < airTemperature.Length; i++)
                    stack.push(airTemperature[i]);
                while (!stack.isEmptyStack())
                    Console.WriteLine(stack.pop());

                Console.WriteLine();
                Console.WriteLine("The output of the data set --airTemperature-- in Queue form");
                Console.WriteLine();

                Cities_Queue queue = new Cities_Queue(airTemperature.Length);

                for (int i = 0; i < airTemperature.Length; i++)
                    queue.enQueue(airTemperature[i]);
                while (!queue.isEmptyQueue())
                    Console.WriteLine(queue.deQueue());

                Console.ReadKey();




class Cities_Queue
    {
        public int size;
        public int[] queueArray;
        public int start, end;
        public int numberofElements;

        public Cities_Queue(int x)
        {
            size = x;
            queueArray = new int[size];
            start = 0;
            end = -1;
            numberofElements = 0;
        }

        public void enQueue(int j)
        {
            if (end == size - 1)
                end = -1;
            queueArray[++end] = j;
            numberofElements++;
        }

        public int deQueue()
        {
            int emitted = queueArray[start++];
            if (start == size)
                start = 0;
            numberofElements--;
            return emitted;
        }

        public bool isEmptyQueue()
        {
            return (numberofElements == 0);
        }
    }


