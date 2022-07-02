﻿// Задача 2 Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
int Prompt(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int x1 = Prompt("Введите координату точки X1: ");
int y1 = Prompt("Введите координату точки Y1: ");
int z1 = Prompt("Введите координату точки Z1: ");

int x2 = Prompt("Введите координату точки X2: ");
int y2 = Prompt("Введите координату точки Y2: ");
int z2 = Prompt("Введите координату точки Z2: ");

double result = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
System.Console.WriteLine($"Расстояние между точками равно {result}");