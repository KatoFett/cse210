﻿using GameEngine;
using System.Collections.Generic;
using System.Numerics;

namespace Solitaire
{
    /// <summary>
    /// A stack of cards.
    /// </summary>
    public abstract class CardStack : Sprite
    {
        /// <summary>
        /// Creates a new <see cref="CardStack"/>.
        /// </summary>
        /// <param name="position">The starting position of the card stack.</param>
        public CardStack(Vector2 position)
        {
            Position = position;
            Size = Card.CardSize;
        }

        /// <summary>
        /// The stack of cards.
        /// </summary>
        public Stack<Card> Stack { get; } = new();

        /// <summary>
        /// Adds a card to the stack.
        /// </summary>
        /// <param name="card">The card to add.</param>
        public abstract void AddCard(Card card);

        /// <summary>
        /// Removes a card from the stack.
        /// </summary>
        /// <param name="card">The card to remove.</param>
        public abstract void RemoveCard(Card card);

        /// <summary>
        /// Gets the position for a card.
        /// </summary>
        public abstract Vector2 GetNextCardPosition();
    }
}
