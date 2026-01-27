# Semana 1: Introducción a C# y .NET

En esta semana daremos los primeros pasos con el ecosistema de Microsoft y el lenguaje C#. Veremos:
- Instalación de **.NET SDK**
- Configuración del entorno (Visual Studio o VS Code)
- Variables y Tipado Fuerte
- Expresiones y Sentencias
- Estructuras de Control (Condicionales)
- Métodos (Funciones)
- Bucles (Iteración)
- Cadenas de texto (Strings)

---

## Variables

A diferencia de Python (que es de tipado dinámico), **C# es un lenguaje de tipado estático**. Esto significa que normalmente debes especificar qué tipo de dato vas a guardar.

### Nombres de Variables (Identificadores)

El identificador debe comenzar por una letra o `_`. El resto puede ser alfanumérico y también puede contener `_`.

- **Identificadores bien construidos:**
```csharp
int numero;
int _numero;
int numero3;
string primer_apellido;
string primerApellido;
```

- **Identificadores mal construidos:**
```csharp
int 3numero;            // No puede empezar con número
string primer apellido;  // No puede tener espacios
float &numero;           // No puede tener símbolos especiales
double primer%apellido;  // No puede tener símbolos especiales
```

- **Case Sensitive:**
```csharp
int 3numero;            // No puede empezar con número
string primer apellido;  // No puede tener espacios
float &numero;           // No puede tener símbolos especiales
double primer%apellido;  // No puede tener símbolos especiales
```