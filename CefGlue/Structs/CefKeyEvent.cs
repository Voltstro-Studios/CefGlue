﻿namespace Xilium.CefGlue
{
    using System;
    using Xilium.CefGlue.Interop;

    public sealed class CefKeyEvent
    {
        private CefKeyEventType _type;
        private CefEventFlags _modifiers;
        private int _windowsKeyCode;
        private int _nativeKeyCode;
        private bool _isSystemKey;
        private char _character;
        private char _unmodifiedCharacter;
        private bool _focusOnEditableField;

        public CefKeyEvent()
        {
        }

        /// <summary>
        /// The type of keyboard event.
        /// </summary>
        public CefKeyEventType EventType
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        /// Bit flags describing any pressed modifier keys. See
        /// cef_event_flags_t for values.
        /// </summary>
        public CefEventFlags Modifiers
        {
            get { return _modifiers; }
            set { _modifiers = value; }
        }

        /// <summary>
        /// The Windows key code for the key event. This value is used by the DOM
        /// specification. Sometimes it comes directly from the event (i.e. on
        /// Windows) and sometimes it's determined using a mapping function. See
        /// WebCore/platform/chromium/KeyboardCodes.h for the list of values.
        /// </summary>
        public int WindowsKeyCode
        {
            get { return _windowsKeyCode; }
            set { _windowsKeyCode = value; }
        }

        /// <summary>
        /// The actual key code genenerated by the platform.
        /// </summary>
        public int NativeKeyCode
        {
            get { return _nativeKeyCode; }
            set { _nativeKeyCode = value; }
        }

        /// <summary>
        /// Indicates whether the event is considered a "system key" event (see
        /// http://msdn.microsoft.com/en-us/library/ms646286(VS.85).aspx for details).
        /// This value will always be false on non-Windows platforms.
        /// </summary>
        public bool IsSystemKey
        {
            get { return _isSystemKey; }
            set { _isSystemKey = value; }
        }

        /// <summary>
        /// The character generated by the keystroke.
        /// </summary>
        public char Character
        {
            get { return _character; }
            set { _character = value; }
        }

        /// <summary>
        /// Same as |character| but unmodified by any concurrently-held modifiers
        /// (except shift). This is useful for working out shortcut keys.
        /// </summary>
        public char UnmodifiedCharacter
        {
            get { return _unmodifiedCharacter; }
            set { _unmodifiedCharacter = value; }
        }

        /// <summary>
        /// True if the focus is currently on an editable field on the page. This is
        /// useful for determining if standard key events should be intercepted.
        /// </summary>
        public bool FocusOnEditableField
        {
            get { return _focusOnEditableField; }
            set { _focusOnEditableField = value; }
        }

        #region Interop

        internal static unsafe CefKeyEvent FromNative(cef_key_event_t* ptr)
        {
            if (ptr == null) throw new ArgumentNullException("ptr");

            return new CefKeyEvent
            {
                EventType = ptr->type,
                Modifiers = ptr->modifiers,
                WindowsKeyCode = ptr->windows_key_code,
                NativeKeyCode = ptr->native_key_code,
                IsSystemKey = ptr->is_system_key != 0,
                Character = (char)ptr->character,
                UnmodifiedCharacter = (char)ptr->unmodified_character,
                FocusOnEditableField = ptr->focus_on_editable_field != 0,
            };
        }

        internal unsafe void ToNative(cef_key_event_t* ptr)
        {
            if (ptr == null) throw new ArgumentNullException("ptr");

            ptr->type = EventType;
            ptr->modifiers = Modifiers;
            ptr->windows_key_code = WindowsKeyCode;
            ptr->native_key_code = NativeKeyCode;
            ptr->is_system_key = IsSystemKey ? 1 : 0;
            ptr->character = Character;
            ptr->unmodified_character = UnmodifiedCharacter;
            ptr->focus_on_editable_field = FocusOnEditableField ? 1 : 0;
        }

        #endregion
    }
}
