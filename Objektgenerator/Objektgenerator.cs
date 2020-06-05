using System;
using System.Collections.Generic;
using System.Text;

namespace Objektgenerator
{
    class Objektgenerator
    {
        /// <summary>
        /// Creates new Objekt of T without parameter in constructor
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T GetNewObject<T>() where T : new()
        {
            return new T();
        }
        /// <summary>
        /// Creates a list of Objekts of T without parameter in constructor
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="amountOfObjects"></param>
        /// <returns></returns>
        public List<T> GetNewObjects<T>(int amountOfObjects) where T : new()
        {
            List<T> list = new List<T>();
            for (int i = 0; i <= amountOfObjects; i++)
            {
                list.Add(new T());
                list.Add((T)Activator.CreateInstance(typeof(T)));
            }
            return list;
        }
        /// <summary>
        /// Creates a new Object of T with parameter in constructor
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T GetNewObjectWithPara<T>(params object[] args)
        {
            var param = typeof(T).GetConstructor(System.Reflection.BindingFlags.Public).GetParameters();
            return (T)Activator.CreateInstance(typeof(T), args);
        }

        /// <summary>
        /// Creates a list of Objekts of T with parameter in constructor
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public List<T> GetNewObjectsWithPara<T>(int amountOfObjects, params object[] args)
        {
            List<T> list = new List<T>();
            for (int i = 0; i <= amountOfObjects; i++)
            {
                list.Add((T)Activator.CreateInstance(typeof(T), args));
            }
            return list;
        }

    }
}
