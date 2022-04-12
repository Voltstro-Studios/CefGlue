﻿//
// This file manually written from cef/include/internal/cef_types.h.
// C API name: cef_dom_node_type_t.
//

namespace Xilium.CefGlue;

/// <summary>
///     DOM node types.
/// </summary>
public enum CefDomNodeType
{
    Unsupported = 0,
    Element,
    Attribute,
    Text,
    CDataSection,
    ProcessingInstruction,
    Comment,
    Document,
    DocumentType,
    DocumentFragment
}