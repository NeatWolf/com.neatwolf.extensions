using System;
using System.Collections.Generic;
using UnityEngine;

namespace NeatWolf.Extensions
{
    public static class Singletons
    {
        private static Dictionary<Type, Component> m_singletons = new Dictionary<Type, Component>();

        public static void RegisterAsSingleton<T>(this T component) where T:Component
        {
            m_singletons[typeof(T)] = component;
        }

        /*public static T GetSingleton<T>(this Component component) where T:Component
        {
            return (T)m_singletons[typeof(T)];
        }*/
        
        //[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
        public static T Get<T>() where T:Component
        {
            try
            {
                return (T)m_singletons[typeof(T)];
            }
            catch (Exception)
            {
                return null;
                //Console.WriteLine(e);
                //throw;
            }

            //Type t = mono.GetType();
            //if (!m_singletons.ContainsKey(type))
            //    m_singletons[type] = (MonoBehaviour)Object.FindObjectOfType(type);

            //return m_singletons[type];
        }
    }
}