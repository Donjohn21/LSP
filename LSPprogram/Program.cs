using System;
//john aquino disla 2022-0417
public abstract class Course
{
    public int CourseId { get; set; }
    public string Title { get; set; }

    // Método abstracto para suscribirse al curso
    public abstract void Subscribe(Student std);

    // Método abstracto para obtener detalles del curso
    public abstract string GetCourseDetails();
}

public class OnlineCourse : Course
{
    public override void Subscribe(Student std)
    {
        // Código para suscribirse a un curso en línea
        Console.WriteLine($"{std.Name} se ha suscrito al curso en línea: {Title}.");
    }

    public override string GetCourseDetails()
    {
        return $"Online Course: {Title}, ID: {CourseId}";
    }
}

public class OfflineCourse : Course
{
    public override void Subscribe(Student std)
    {
        // Código para suscribirse a un curso presencial
        Console.WriteLine($"{std.Name} se ha suscrito al curso presencial: {Title}.");
    }

    public override string GetCourseDetails()
    {
        return $"Offline Course: {Title}, ID: {CourseId}";
    }
}

public class HybridCourse : Course
{
    public override void Subscribe(Student std)
    {
        // Código para suscribirse a un curso híbrido
        Console.WriteLine($"{std.Name} se ha suscrito al curso híbrido: {Title}.");
    }

    public override string GetCourseDetails()
    {
        return $"Hybrid Course: {Title}, ID: {CourseId}";
    }
}

// Clase Student como placeholder
public class Student
{
    public string Name { get; set; }
}

// Código cliente para probar la implementación
public class Program
{
    public static void Main()
    {
        // Crear instancias de los cursos
        Course onlineCourse = new OnlineCourse { CourseId = 1, Title = "Introducción a la Programación" };
        Course offlineCourse = new OfflineCourse { CourseId = 2, Title = "Matemáticas Avanzadas" };
        Course hybridCourse = new HybridCourse { CourseId = 3, Title = "Gestión de Proyectos" };

        // Crear una instancia de Student
        Student student = new Student { Name = "John aquino" };

        // Suscribir al estudiante a los cursos
        onlineCourse.Subscribe(student);
        offlineCourse.Subscribe(student);
        hybridCourse.Subscribe(student);

        // Obtener y mostrar detalles de los cursos
        Console.WriteLine(onlineCourse.GetCourseDetails());
        Console.WriteLine(offlineCourse.GetCourseDetails());
        Console.WriteLine(hybridCourse.GetCourseDetails());
    }
}
