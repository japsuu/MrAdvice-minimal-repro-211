using System.Reflection;
using ArxOne.MrAdvice.Advice;

namespace ClassLibrary1;

[AttributeUsage(AttributeTargets.Method)]
public class ExampleAttribute : Attribute, IMethodAdvice
{
    public void Advise(MethodAdviceContext context)
    {
        // Remove the following line, and the project compiles successfully
        const BindingFlags flags = BindingFlags.Instance | BindingFlags.NonPublic;

        context.Proceed();
    }
}