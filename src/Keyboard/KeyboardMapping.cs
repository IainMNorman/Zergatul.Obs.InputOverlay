using System.Collections.Generic;

namespace Zergatul.Obs.InputOverlay.Keyboard
{
    public static class KeyboardMapping
    {
        public static readonly Dictionary<int, KeyboardButton> Dictionary = new Dictionary<int, KeyboardButton>
        {
            [0x1E] = KeyboardButton.KeyA,
            [0x30] = KeyboardButton.KeyB,
            [0x2E] = KeyboardButton.KeyC,
            [0x20] = KeyboardButton.KeyD,
            [0x12] = KeyboardButton.KeyE,
            [0x21] = KeyboardButton.KeyF,
            [0x22] = KeyboardButton.KeyG,
            [0x23] = KeyboardButton.KeyH,
            [0x17] = KeyboardButton.KeyI,
            [0x24] = KeyboardButton.KeyJ,
            [0x25] = KeyboardButton.KeyK,
            [0x26] = KeyboardButton.KeyL,
            [0x32] = KeyboardButton.KeyM,
            [0x31] = KeyboardButton.KeyN,
            [0x18] = KeyboardButton.KeyO,
            [0x19] = KeyboardButton.KeyP,
            [0x10] = KeyboardButton.KeyQ,
            [0x13] = KeyboardButton.KeyR,
            [0x1F] = KeyboardButton.KeyS,
            [0x14] = KeyboardButton.KeyT,
            [0x16] = KeyboardButton.KeyU,
            [0x2F] = KeyboardButton.KeyV,
            [0x11] = KeyboardButton.KeyW,
            [0x2D] = KeyboardButton.KeyX,
            [0x15] = KeyboardButton.KeyY,
            [0x2C] = KeyboardButton.KeyZ,
            [0x02] = KeyboardButton.Key1,
            [0x03] = KeyboardButton.Key2,
            [0x04] = KeyboardButton.Key3,
            [0x05] = KeyboardButton.Key4,
            [0x06] = KeyboardButton.Key5,
            [0x07] = KeyboardButton.Key6,
            [0x08] = KeyboardButton.Key7,
            [0x09] = KeyboardButton.Key8,
            [0x0A] = KeyboardButton.Key9,
            [0x0B] = KeyboardButton.Key0,
            [0x1C] = KeyboardButton.Enter,
            [0x01] = KeyboardButton.Esc,
            [0x0E] = KeyboardButton.Backspace,
            [0x0F] = KeyboardButton.Tab,
            [0x39] = KeyboardButton.Space,
            [0x0C] = KeyboardButton.Minus,
            [0x0D] = KeyboardButton.Plus,
            [0x1A] = KeyboardButton.LeftBracket,
            [0x1B] = KeyboardButton.RightBracket,
            [0x2B] = KeyboardButton.Backslash,
            [0x27] = KeyboardButton.Semicolon,
            [0x28] = KeyboardButton.Quote,
            [0x29] = KeyboardButton.Tilde,
            [0x33] = KeyboardButton.Comma,
            [0x34] = KeyboardButton.Period,
            [0x35] = KeyboardButton.Slash,
            [0x3A] = KeyboardButton.CapsLock,
            [0x3B] = KeyboardButton.F1,
            [0x3C] = KeyboardButton.F2,
            [0x3D] = KeyboardButton.F3,
            [0x3E] = KeyboardButton.F4,
            [0x3F] = KeyboardButton.F5,
            [0x40] = KeyboardButton.F6,
            [0x41] = KeyboardButton.F7,
            [0x42] = KeyboardButton.F8,
            [0x43] = KeyboardButton.F9,
            [0x44] = KeyboardButton.F10,
            [0x57] = KeyboardButton.F11,
            [0x58] = KeyboardButton.F12,
            [0x46] = KeyboardButton.ScrollLock,
            [0x45] = KeyboardButton.NumLock,
            [0x37] = KeyboardButton.NumAsterisk,
            [0x4A] = KeyboardButton.NumMinus,
            [0x4E] = KeyboardButton.NumPlus,
            [0x4F] = KeyboardButton.Num1,
            [0x50] = KeyboardButton.Num2,
            [0x51] = KeyboardButton.Num3,
            [0x4B] = KeyboardButton.Num4,
            [0x4C] = KeyboardButton.Num5,
            [0x4D] = KeyboardButton.Num6,
            [0x47] = KeyboardButton.Num7,
            [0x48] = KeyboardButton.Num8,
            [0x49] = KeyboardButton.Num9,
            [0x52] = KeyboardButton.Num0,
            [0x53] = KeyboardButton.NumPeriod,
            [0x1D] = KeyboardButton.LeftCtrl,
            [0x2A] = KeyboardButton.LeftShift,
            [0x38] = KeyboardButton.LeftAlt,
            [0x36] = KeyboardButton.RightShift,
            //[0x59] = KeyboardButton.KeyKeypad =,
            /*[0x64] = KeyboardButton.KeyF13,
            [0x65] = KeyboardButton.KeyF14,
            [0x66] = KeyboardButton.KeyF15,
            [0x67] = KeyboardButton.KeyF16,
            [0x68] = KeyboardButton.KeyF17,
            [0x69] = KeyboardButton.KeyF18,
            [0x6A] = KeyboardButton.KeyF19,
            [0x6B] = KeyboardButton.KeyF20,
            [0x6C] = KeyboardButton.KeyF21,
            [0x6D] = KeyboardButton.KeyF22,
            [0x6E] = KeyboardButton.KeyF23,
            [0x76] = KeyboardButton.KeyF24,*/

            [0xE052] = KeyboardButton.Insert,
            [0xE047] = KeyboardButton.Home,
            [0xE049] = KeyboardButton.PageUp,
            [0xE053] = KeyboardButton.Delete,
            [0xE04F] = KeyboardButton.End,
            [0xE051] = KeyboardButton.PageDown,
            [0xE04D] = KeyboardButton.Right,
            [0xE04B] = KeyboardButton.Left,
            [0xE050] = KeyboardButton.Down,
            [0xE048] = KeyboardButton.Up,
            [0xE05B] = KeyboardButton.LeftWindows,
            [0xE01D] = KeyboardButton.RightCtrl,
            [0xE038] = KeyboardButton.RightAlt,
            [0xE05C] = KeyboardButton.RightWindows,

            //[0x56] = KeyboardButton.KeyEurope 2 (Note 2),

            //"[0xE0 46 E0 C6] = KeyboardButton.KeyBreak (Ctrl-Pause),"
            //"[0xE1 1D 45 E1 9D C5] = KeyboardButton.KeyPause,"


            [0xE037] = KeyboardButton.PrintScreen,
            [0xE035] = KeyboardButton.NumSlash,
            [0xE01C] = KeyboardButton.NumEnter,
            [0xE05D] = KeyboardButton.App,
            //[0xE05E] = KeyboardButton.Power,

            [0xE11D] = KeyboardButton.Pause
        };
    }
}