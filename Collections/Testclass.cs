using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public static class Testclass
    {
        /// <summary>
        /// Met à jour la priorité d'un élément spécifique dans la file d'attente prioritaire.
        /// </summary>
        /// <typeparam name="TElement">Le type des éléments dans la file d'attente prioritaire.</typeparam>
        /// <typeparam name="TPriority">Le type de la priorité associée aux éléments.</typeparam>
        /// <param name="queue">La file d'attente prioritaire à mettre à jour.</param>
        /// <param name="element">L'élément dont la priorité doit être mise à jour.</param>
        /// <param name="priority">La nouvelle priorité pour l'élément spécifié.</param>
        public static void UpdatePriority<TElement, TPriority>(
            this PriorityQueue<TElement, TPriority> queue,
            TElement element,
            TPriority priority
        )
        {
            // Parcourir le tas pour trouver les entrées correspondant à l'élément actuel.
            queue.Remove(element, out _, out _);
            // Réinsérer l'entrée avec la nouvelle priorité.
            queue.Enqueue(element, priority);
        }
    }
}
