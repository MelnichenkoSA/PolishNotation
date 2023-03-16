using System;
using System.Collections.Generic;
using System.Text;

namespace PolishNotation
{
    class Node<T>
    {
        /// <summary>
        /// Возвращает значение, содержащееся в узле.
        /// </summary>
        internal T? Data { get; }

        /// <summary>
        /// Получает и устанавливает ссылку на связный узел.
        /// </summary>
        internal Node<T>? Link { get; set; }

        /// <summary>
        /// Инициализирует новый экземпляр класса LinkedNode, содержащего указанное значение.
        /// </summary>
        /// <param name="data">Значение, которое должно содержаться в списке.</param>
        internal Node(T? data = default) => Data = data;
    }
}

