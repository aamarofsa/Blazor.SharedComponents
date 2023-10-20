namespace Base.Models
{
    public enum TextAlign
    {
        //
        // Resumen:
        //     The text is aligned to the left side of its container.
        Left,
        //
        // Resumen:
        //     The text is aligned to the right side of its container.
        Right,
        //
        // Resumen:
        //     The text is centered in its container.
        Center,
        //
        // Resumen:
        //     The text is justified.
        Justify,
        //
        // Resumen:
        //     Same as justify, but also forces the last line to be justified.
        JustifyAll,
        //
        // Resumen:
        //     The same as left if direction is left-to-right and right if direction is right-to-left..
        Start,
        //
        // Resumen:
        //     The same as right if direction is left-to-right and left if direction is right-to-left..
        End
    }
}
