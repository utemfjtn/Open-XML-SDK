﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Drawing.Charts;

namespace DocumentFormat.OpenXml.Office2016.Drawing.Charts
{
/// <summary>
/// <para>Defines the ShapeProperties Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c16:spPr.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Transform2D &lt;a:xfrm></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.CustomGeometry &lt;a:custGeom></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.PresetGeometry &lt;a:prstGeom></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.NoFill &lt;a:noFill></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.SolidFill &lt;a:solidFill></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.GradientFill &lt;a:gradFill></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.BlipFill &lt;a:blipFill></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.PatternFill &lt;a:pattFill></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.GroupFill &lt;a:grpFill></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Outline &lt;a:ln></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.EffectList &lt;a:effectLst></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.EffectDag &lt;a:effectDag></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Scene3DType &lt;a:scene3d></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Shape3DType &lt;a:sp3d></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.ShapePropertiesExtensionList &lt;a:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Transform2D))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.CustomGeometry))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.PresetGeometry))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.NoFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.SolidFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.GradientFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.BlipFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.PatternFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.GroupFill))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Outline))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.EffectList))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.EffectDag))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Scene3DType))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Shape3DType))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.ShapePropertiesExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class ShapeProperties : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13518;
    /// <inheritdoc/>
    public override string LocalName => "spPr";
    
    internal override byte NamespaceId => 82;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override bool IsInVersion(FileFormatVersions version) => version.AtLeast(FileFormatVersions.Office2016);
    

    	private static readonly string[] attributeTagNames = { "bwMode" };
    private static readonly byte[] attributeNamespaceIds = { 0 };
    
    internal override string[] AttributeTagNames => attributeTagNames;
    
    internal override byte[] AttributeNamespaceIds => attributeNamespaceIds;
    

    
        /// <summary>
    /// <para> Black and White Mode.</para>
    /// <para>Represents the following attribute in the schema: bwMode </para>
    /// </summary>
    [SchemaAttr(0, "bwMode")]
    public EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues> BlackWhiteMode
    {
        get { return (EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the ShapeProperties class.
    /// </summary>
    public ShapeProperties():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ShapeProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ShapeProperties(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ShapeProperties class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ShapeProperties(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ShapeProperties class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ShapeProperties(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 10 == namespaceId && "xfrm" == name)
    return new DocumentFormat.OpenXml.Drawing.Transform2D();
    
if( 10 == namespaceId && "custGeom" == name)
    return new DocumentFormat.OpenXml.Drawing.CustomGeometry();
    
if( 10 == namespaceId && "prstGeom" == name)
    return new DocumentFormat.OpenXml.Drawing.PresetGeometry();
    
if( 10 == namespaceId && "noFill" == name)
    return new DocumentFormat.OpenXml.Drawing.NoFill();
    
if( 10 == namespaceId && "solidFill" == name)
    return new DocumentFormat.OpenXml.Drawing.SolidFill();
    
if( 10 == namespaceId && "gradFill" == name)
    return new DocumentFormat.OpenXml.Drawing.GradientFill();
    
if( 10 == namespaceId && "blipFill" == name)
    return new DocumentFormat.OpenXml.Drawing.BlipFill();
    
if( 10 == namespaceId && "pattFill" == name)
    return new DocumentFormat.OpenXml.Drawing.PatternFill();
    
if( 10 == namespaceId && "grpFill" == name)
    return new DocumentFormat.OpenXml.Drawing.GroupFill();
    
if( 10 == namespaceId && "ln" == name)
    return new DocumentFormat.OpenXml.Drawing.Outline();
    
if( 10 == namespaceId && "effectLst" == name)
    return new DocumentFormat.OpenXml.Drawing.EffectList();
    
if( 10 == namespaceId && "effectDag" == name)
    return new DocumentFormat.OpenXml.Drawing.EffectDag();
    
if( 10 == namespaceId && "scene3d" == name)
    return new DocumentFormat.OpenXml.Drawing.Scene3DType();
    
if( 10 == namespaceId && "sp3d" == name)
    return new DocumentFormat.OpenXml.Drawing.Shape3DType();
    
if( 10 == namespaceId && "extLst" == name)
    return new DocumentFormat.OpenXml.Drawing.ShapePropertiesExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "xfrm","custGeom","prstGeom","noFill","solidFill","gradFill","blipFill","pattFill","grpFill","ln","effectLst","effectDag","scene3d","sp3d","extLst" };
    private static readonly byte[] eleNamespaceIds = { 10,10,10,10,10,10,10,10,10,10,10,10,10,10,10 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> 2D Transform for Individual Objects.</para>
    /// <para> Represents the following element tag in the schema: a:xfrm </para>
    /// </summary>
    /// <remark>
    /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Transform2D Transform2D
    {
        get => GetElement<DocumentFormat.OpenXml.Drawing.Transform2D>(0);
        set => SetElement(0, value);
    }


    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "bwMode" == name)
    return new EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>();
    

    
    return base.AttributeFactory(namespaceId, name);
}

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShapeProperties>(deep);

}
/// <summary>
/// <para>Defines the UnsignedIntegerType Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c16:explosion.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class UnsignedIntegerType : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13519;
    /// <inheritdoc/>
    public override string LocalName => "explosion";
    
    internal override byte NamespaceId => 82;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override bool IsInVersion(FileFormatVersions version) => version.AtLeast(FileFormatVersions.Office2016);
    

    	private static readonly string[] attributeTagNames = { "val" };
    private static readonly byte[] attributeNamespaceIds = { 0 };
    
    internal override string[] AttributeTagNames => attributeTagNames;
    
    internal override byte[] AttributeNamespaceIds => attributeNamespaceIds;
    

    
        /// <summary>
    /// <para> Integer Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public UInt32Value Val
    {
        get { return (UInt32Value)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the UnsignedIntegerType class.
    /// </summary>
    public UnsignedIntegerType():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "val" == name)
    return new UInt32Value();
    

    
    return base.AttributeFactory(namespaceId, name);
}

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<UnsignedIntegerType>(deep);

}
/// <summary>
/// <para>Defines the InvertIfNegativeBoolean Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c16:invertIfNegative.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class InvertIfNegativeBoolean : BooleanType
{
    internal const int ElementTypeIdConst = 13520;
    /// <inheritdoc/>
    public override string LocalName => "invertIfNegative";
    
    internal override byte NamespaceId => 82;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override bool IsInVersion(FileFormatVersions version) => version.AtLeast(FileFormatVersions.Office2016);
    

    /// <summary>
    /// Initializes a new instance of the InvertIfNegativeBoolean class.
    /// </summary>
    public InvertIfNegativeBoolean():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<InvertIfNegativeBoolean>(deep);

}
/// <summary>
/// <para>Defines the Bubble3DBoolean Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c16:bubble3D.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class Bubble3DBoolean : BooleanType
{
    internal const int ElementTypeIdConst = 13521;
    /// <inheritdoc/>
    public override string LocalName => "bubble3D";
    
    internal override byte NamespaceId => 82;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override bool IsInVersion(FileFormatVersions version) => version.AtLeast(FileFormatVersions.Office2016);
    

    /// <summary>
    /// Initializes a new instance of the Bubble3DBoolean class.
    /// </summary>
    public Bubble3DBoolean():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Bubble3DBoolean>(deep);

}
/// <summary>
/// Defines the BooleanType class.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class BooleanType : OpenXmlLeafElement
{
    	private static readonly string[] attributeTagNames = { "val" };
    private static readonly byte[] attributeNamespaceIds = { 0 };
    
    internal override string[] AttributeTagNames => attributeTagNames;
    
    internal override byte[] AttributeNamespaceIds => attributeNamespaceIds;
    
    
        /// <summary>
    /// <para> Boolean Value.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public BooleanValue Val
    {
        get { return (BooleanValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "val" == name)
    return new BooleanValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

    
    /// <summary>
    /// Initializes a new instance of the BooleanType class.
    /// </summary>
    protected BooleanType(){}
    
    
    
}
/// <summary>
/// <para>Defines the Marker Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c16:marker.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Symbol &lt;c:symbol></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Size &lt;c:size></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties &lt;c:spPr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Symbol))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Size))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class Marker : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13522;
    /// <inheritdoc/>
    public override string LocalName => "marker";
    
    internal override byte NamespaceId => 82;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override bool IsInVersion(FileFormatVersions version) => version.AtLeast(FileFormatVersions.Office2016);
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the Marker class.
    /// </summary>
    public Marker():base(){}
    
        /// <summary>
    ///Initializes a new instance of the Marker class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Marker(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the Marker class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public Marker(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the Marker class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public Marker(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "symbol" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.Symbol();
    
if( 11 == namespaceId && "size" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.Size();
    
if( 11 == namespaceId && "spPr" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties();
    
if( 11 == namespaceId && "extLst" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "symbol","size","spPr","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11,11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Symbol.</para>
    /// <para> Represents the following element tag in the schema: c:symbol </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.Symbol Symbol
    {
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Symbol>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Size.</para>
    /// <para> Represents the following element tag in the schema: c:size </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.Size Size
    {
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Size>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> ChartShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: c:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties ChartShapeProperties
    {
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>(2);
        set => SetElement(2, value);
    }
    /// <summary>
    /// <para> Chart Extensibility.</para>
    /// <para> Represents the following element tag in the schema: c:extLst </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.ExtensionList ExtensionList
    {
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>(3);
        set => SetElement(3, value);
    }


    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<Marker>(deep);

}
/// <summary>
/// <para>Defines the DLbl Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c16:dLbl.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Index &lt;c:idx></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Delete &lt;c:delete></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Layout &lt;c:layout></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ChartText &lt;c:tx></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.NumberingFormat &lt;c:numFmt></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties &lt;c:spPr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.TextProperties &lt;c:txPr></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.DataLabelPosition &lt;c:dLblPos></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ShowLegendKey &lt;c:showLegendKey></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ShowValue &lt;c:showVal></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ShowCategoryName &lt;c:showCatName></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ShowSeriesName &lt;c:showSerName></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ShowPercent &lt;c:showPercent></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ShowBubbleSize &lt;c:showBubbleSize></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Separator &lt;c:separator></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.DLblExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Index))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Delete))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Layout))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartText))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.NumberingFormat))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.TextProperties))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.DataLabelPosition))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ShowLegendKey))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ShowValue))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ShowCategoryName))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ShowSeriesName))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ShowPercent))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ShowBubbleSize))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Separator))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.DLblExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class DLbl : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13523;
    /// <inheritdoc/>
    public override string LocalName => "dLbl";
    
    internal override byte NamespaceId => 82;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override bool IsInVersion(FileFormatVersions version) => version.AtLeast(FileFormatVersions.Office2016);
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the DLbl class.
    /// </summary>
    public DLbl():base(){}
    
        /// <summary>
    ///Initializes a new instance of the DLbl class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DLbl(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the DLbl class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public DLbl(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the DLbl class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public DLbl(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "idx" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.Index();
    
if( 11 == namespaceId && "delete" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.Delete();
    
if( 11 == namespaceId && "layout" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.Layout();
    
if( 11 == namespaceId && "tx" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.ChartText();
    
if( 11 == namespaceId && "numFmt" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.NumberingFormat();
    
if( 11 == namespaceId && "spPr" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties();
    
if( 11 == namespaceId && "txPr" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.TextProperties();
    
if( 11 == namespaceId && "dLblPos" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.DataLabelPosition();
    
if( 11 == namespaceId && "showLegendKey" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.ShowLegendKey();
    
if( 11 == namespaceId && "showVal" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.ShowValue();
    
if( 11 == namespaceId && "showCatName" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.ShowCategoryName();
    
if( 11 == namespaceId && "showSerName" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.ShowSeriesName();
    
if( 11 == namespaceId && "showPercent" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.ShowPercent();
    
if( 11 == namespaceId && "showBubbleSize" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.ShowBubbleSize();
    
if( 11 == namespaceId && "separator" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.Separator();
    
if( 11 == namespaceId && "extLst" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.DLblExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "idx","delete","layout","tx","numFmt","spPr","txPr","dLblPos","showLegendKey","showVal","showCatName","showSerName","showPercent","showBubbleSize","separator","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Index.</para>
    /// <para> Represents the following element tag in the schema: c:idx </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.Index Index
    {
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.Index>(0);
        set => SetElement(0, value);
    }


    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<DLbl>(deep);

}
/// <summary>
/// <para>Defines the CategoryFilterExceptions Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c16:categoryFilterExceptions.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>CategoryFilterException &lt;c16:categoryFilterException></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(CategoryFilterException), FileFormatVersions.Office2016)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class CategoryFilterExceptions : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13524;
    /// <inheritdoc/>
    public override string LocalName => "categoryFilterExceptions";
    
    internal override byte NamespaceId => 82;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override bool IsInVersion(FileFormatVersions version) => version.AtLeast(FileFormatVersions.Office2016);
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the CategoryFilterExceptions class.
    /// </summary>
    public CategoryFilterExceptions():base(){}
    
        /// <summary>
    ///Initializes a new instance of the CategoryFilterExceptions class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public CategoryFilterExceptions(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the CategoryFilterExceptions class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public CategoryFilterExceptions(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the CategoryFilterExceptions class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public CategoryFilterExceptions(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 82 == namespaceId && "categoryFilterException" == name)
    return new CategoryFilterException();
    

    return null;
}

    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<CategoryFilterExceptions>(deep);

}
/// <summary>
/// <para>Defines the PivotOptions16 Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c16:pivotOptions16.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>BooleanFalse &lt;c16:showExpandCollapseFieldButtons></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(BooleanFalse), FileFormatVersions.Office2016)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class PivotOptions16 : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13525;
    /// <inheritdoc/>
    public override string LocalName => "pivotOptions16";
    
    internal override byte NamespaceId => 82;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override bool IsInVersion(FileFormatVersions version) => version.AtLeast(FileFormatVersions.Office2016);
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the PivotOptions16 class.
    /// </summary>
    public PivotOptions16():base(){}
    
        /// <summary>
    ///Initializes a new instance of the PivotOptions16 class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PivotOptions16(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the PivotOptions16 class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public PivotOptions16(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the PivotOptions16 class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public PivotOptions16(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 82 == namespaceId && "showExpandCollapseFieldButtons" == name)
    return new BooleanFalse();
    

    return null;
}

        private static readonly string[] eleTagNames = { "showExpandCollapseFieldButtons" };
    private static readonly byte[] eleNamespaceIds = { 82 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> BooleanFalse.</para>
    /// <para> Represents the following element tag in the schema: c16:showExpandCollapseFieldButtons </para>
    /// </summary>
    /// <remark>
    /// xmlns:c16 = http://schemas.microsoft.com/office/drawing/2014/chart
    /// </remark>
    public BooleanFalse BooleanFalse
    {
        get => GetElement<BooleanFalse>(0);
        set => SetElement(0, value);
    }


    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotOptions16>(deep);

}
/// <summary>
/// <para>Defines the ChartDataPointUniqueIDMap Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c16:datapointuniqueidmap.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>ChartDataPointUniqueIDMapEntry &lt;c16:ptentry></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(ChartDataPointUniqueIDMapEntry), FileFormatVersions.Office2016)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class ChartDataPointUniqueIDMap : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13526;
    /// <inheritdoc/>
    public override string LocalName => "datapointuniqueidmap";
    
    internal override byte NamespaceId => 82;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override bool IsInVersion(FileFormatVersions version) => version.AtLeast(FileFormatVersions.Office2016);
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the ChartDataPointUniqueIDMap class.
    /// </summary>
    public ChartDataPointUniqueIDMap():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ChartDataPointUniqueIDMap class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ChartDataPointUniqueIDMap(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ChartDataPointUniqueIDMap class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ChartDataPointUniqueIDMap(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ChartDataPointUniqueIDMap class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ChartDataPointUniqueIDMap(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 82 == namespaceId && "ptentry" == name)
    return new ChartDataPointUniqueIDMapEntry();
    

    return null;
}

    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ChartDataPointUniqueIDMap>(deep);

}
/// <summary>
/// <para>Defines the UniqueIdChartUniqueID Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c16:uniqueId.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class UniqueIdChartUniqueID : UniqueIDChart
{
    internal const int ElementTypeIdConst = 13527;
    /// <inheritdoc/>
    public override string LocalName => "uniqueId";
    
    internal override byte NamespaceId => 82;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override bool IsInVersion(FileFormatVersions version) => version.AtLeast(FileFormatVersions.Office2016);
    

    /// <summary>
    /// Initializes a new instance of the UniqueIdChartUniqueID class.
    /// </summary>
    public UniqueIdChartUniqueID():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<UniqueIdChartUniqueID>(deep);

}
/// <summary>
/// <para>Defines the UniqueID Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c16:uniqueID.</para>
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class UniqueID : UniqueIDChart
{
    internal const int ElementTypeIdConst = 13538;
    /// <inheritdoc/>
    public override string LocalName => "uniqueID";
    
    internal override byte NamespaceId => 82;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override bool IsInVersion(FileFormatVersions version) => version.AtLeast(FileFormatVersions.Office2016);
    

    /// <summary>
    /// Initializes a new instance of the UniqueID class.
    /// </summary>
    public UniqueID():base(){}
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<UniqueID>(deep);

}
/// <summary>
/// Defines the UniqueIDChart class.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "2.0")]
public abstract partial class UniqueIDChart : OpenXmlLeafElement
{
    	private static readonly string[] attributeTagNames = { "val" };
    private static readonly byte[] attributeNamespaceIds = { 0 };
    
    internal override string[] AttributeTagNames => attributeTagNames;
    
    internal override byte[] AttributeNamespaceIds => attributeNamespaceIds;
    
    
        /// <summary>
    /// <para> val.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public StringValue Val
    {
        get { return (StringValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "val" == name)
    return new StringValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

    
    /// <summary>
    /// Initializes a new instance of the UniqueIDChart class.
    /// </summary>
    protected UniqueIDChart(){}
    
    
    
}
/// <summary>
/// <para>Defines the CategoryFilterException Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c16:categoryFilterException.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>UniqueIdChartUniqueID &lt;c16:uniqueId></description></item>
///<item><description>ShapeProperties &lt;c16:spPr></description></item>
///<item><description>UnsignedIntegerType &lt;c16:explosion></description></item>
///<item><description>InvertIfNegativeBoolean &lt;c16:invertIfNegative></description></item>
///<item><description>Bubble3DBoolean &lt;c16:bubble3D></description></item>
///<item><description>Marker &lt;c16:marker></description></item>
///<item><description>DLbl &lt;c16:dLbl></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(UniqueIdChartUniqueID), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(ShapeProperties), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(UnsignedIntegerType), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(InvertIfNegativeBoolean), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(Bubble3DBoolean), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(Marker), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(DLbl), FileFormatVersions.Office2016)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class CategoryFilterException : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13528;
    /// <inheritdoc/>
    public override string LocalName => "categoryFilterException";
    
    internal override byte NamespaceId => 82;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override bool IsInVersion(FileFormatVersions version) => version.AtLeast(FileFormatVersions.Office2016);
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the CategoryFilterException class.
    /// </summary>
    public CategoryFilterException():base(){}
    
        /// <summary>
    ///Initializes a new instance of the CategoryFilterException class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public CategoryFilterException(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the CategoryFilterException class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public CategoryFilterException(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the CategoryFilterException class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public CategoryFilterException(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 82 == namespaceId && "uniqueId" == name)
    return new UniqueIdChartUniqueID();
    
if( 82 == namespaceId && "spPr" == name)
    return new ShapeProperties();
    
if( 82 == namespaceId && "explosion" == name)
    return new UnsignedIntegerType();
    
if( 82 == namespaceId && "invertIfNegative" == name)
    return new InvertIfNegativeBoolean();
    
if( 82 == namespaceId && "bubble3D" == name)
    return new Bubble3DBoolean();
    
if( 82 == namespaceId && "marker" == name)
    return new Marker();
    
if( 82 == namespaceId && "dLbl" == name)
    return new DLbl();
    

    return null;
}

        private static readonly string[] eleTagNames = { "uniqueId","spPr","explosion","invertIfNegative","bubble3D","marker","dLbl" };
    private static readonly byte[] eleNamespaceIds = { 82,82,82,82,82,82,82 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> UniqueIdChartUniqueID.</para>
    /// <para> Represents the following element tag in the schema: c16:uniqueId </para>
    /// </summary>
    /// <remark>
    /// xmlns:c16 = http://schemas.microsoft.com/office/drawing/2014/chart
    /// </remark>
    public UniqueIdChartUniqueID UniqueIdChartUniqueID
    {
        get => GetElement<UniqueIdChartUniqueID>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> ShapeProperties.</para>
    /// <para> Represents the following element tag in the schema: c16:spPr </para>
    /// </summary>
    /// <remark>
    /// xmlns:c16 = http://schemas.microsoft.com/office/drawing/2014/chart
    /// </remark>
    public ShapeProperties ShapeProperties
    {
        get => GetElement<ShapeProperties>(1);
        set => SetElement(1, value);
    }
    /// <summary>
    /// <para> UnsignedIntegerType.</para>
    /// <para> Represents the following element tag in the schema: c16:explosion </para>
    /// </summary>
    /// <remark>
    /// xmlns:c16 = http://schemas.microsoft.com/office/drawing/2014/chart
    /// </remark>
    public UnsignedIntegerType UnsignedIntegerType
    {
        get => GetElement<UnsignedIntegerType>(2);
        set => SetElement(2, value);
    }
    /// <summary>
    /// <para> InvertIfNegativeBoolean.</para>
    /// <para> Represents the following element tag in the schema: c16:invertIfNegative </para>
    /// </summary>
    /// <remark>
    /// xmlns:c16 = http://schemas.microsoft.com/office/drawing/2014/chart
    /// </remark>
    public InvertIfNegativeBoolean InvertIfNegativeBoolean
    {
        get => GetElement<InvertIfNegativeBoolean>(3);
        set => SetElement(3, value);
    }
    /// <summary>
    /// <para> Bubble3DBoolean.</para>
    /// <para> Represents the following element tag in the schema: c16:bubble3D </para>
    /// </summary>
    /// <remark>
    /// xmlns:c16 = http://schemas.microsoft.com/office/drawing/2014/chart
    /// </remark>
    public Bubble3DBoolean Bubble3DBoolean
    {
        get => GetElement<Bubble3DBoolean>(4);
        set => SetElement(4, value);
    }
    /// <summary>
    /// <para> Marker.</para>
    /// <para> Represents the following element tag in the schema: c16:marker </para>
    /// </summary>
    /// <remark>
    /// xmlns:c16 = http://schemas.microsoft.com/office/drawing/2014/chart
    /// </remark>
    public Marker Marker
    {
        get => GetElement<Marker>(5);
        set => SetElement(5, value);
    }
    /// <summary>
    /// <para> DLbl.</para>
    /// <para> Represents the following element tag in the schema: c16:dLbl </para>
    /// </summary>
    /// <remark>
    /// xmlns:c16 = http://schemas.microsoft.com/office/drawing/2014/chart
    /// </remark>
    public DLbl DLbl
    {
        get => GetElement<DLbl>(6);
        set => SetElement(6, value);
    }


    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<CategoryFilterException>(deep);

}
/// <summary>
/// <para>Defines the NumberDataType Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c16:numCache.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.FormatCode &lt;c:formatCode></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.PointCount &lt;c:ptCount></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.NumericPoint &lt;c:pt></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.FormatCode))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.PointCount))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.NumericPoint))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class NumberDataType : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13529;
    /// <inheritdoc/>
    public override string LocalName => "numCache";
    
    internal override byte NamespaceId => 82;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override bool IsInVersion(FileFormatVersions version) => version.AtLeast(FileFormatVersions.Office2016);
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the NumberDataType class.
    /// </summary>
    public NumberDataType():base(){}
    
        /// <summary>
    ///Initializes a new instance of the NumberDataType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NumberDataType(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the NumberDataType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NumberDataType(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the NumberDataType class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public NumberDataType(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "formatCode" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.FormatCode();
    
if( 11 == namespaceId && "ptCount" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.PointCount();
    
if( 11 == namespaceId && "pt" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.NumericPoint();
    
if( 11 == namespaceId && "extLst" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "formatCode","ptCount","pt","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11,11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> Format Code.</para>
    /// <para> Represents the following element tag in the schema: c:formatCode </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.FormatCode FormatCode
    {
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.FormatCode>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> Point Count.</para>
    /// <para> Represents the following element tag in the schema: c:ptCount </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.PointCount PointCount
    {
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.PointCount>(1);
        set => SetElement(1, value);
    }


    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<NumberDataType>(deep);

}
/// <summary>
/// <para>Defines the NumFilteredLiteralCache Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c16:filteredLitCache.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>NumberDataType &lt;c16:numCache></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(NumberDataType), FileFormatVersions.Office2016)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class NumFilteredLiteralCache : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13530;
    /// <inheritdoc/>
    public override string LocalName => "filteredLitCache";
    
    internal override byte NamespaceId => 82;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override bool IsInVersion(FileFormatVersions version) => version.AtLeast(FileFormatVersions.Office2016);
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the NumFilteredLiteralCache class.
    /// </summary>
    public NumFilteredLiteralCache():base(){}
    
        /// <summary>
    ///Initializes a new instance of the NumFilteredLiteralCache class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NumFilteredLiteralCache(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the NumFilteredLiteralCache class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public NumFilteredLiteralCache(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the NumFilteredLiteralCache class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public NumFilteredLiteralCache(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 82 == namespaceId && "numCache" == name)
    return new NumberDataType();
    

    return null;
}

        private static readonly string[] eleTagNames = { "numCache" };
    private static readonly byte[] eleNamespaceIds = { 82 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> NumberDataType.</para>
    /// <para> Represents the following element tag in the schema: c16:numCache </para>
    /// </summary>
    /// <remark>
    /// xmlns:c16 = http://schemas.microsoft.com/office/drawing/2014/chart
    /// </remark>
    public NumberDataType NumberDataType
    {
        get => GetElement<NumberDataType>(0);
        set => SetElement(0, value);
    }


    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<NumFilteredLiteralCache>(deep);

}
/// <summary>
/// <para>Defines the StringDataType Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c16:strCache.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.PointCount &lt;c:ptCount></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.StringPoint &lt;c:pt></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.StrDataExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.PointCount))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.StringPoint))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.StrDataExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class StringDataType : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13531;
    /// <inheritdoc/>
    public override string LocalName => "strCache";
    
    internal override byte NamespaceId => 82;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override bool IsInVersion(FileFormatVersions version) => version.AtLeast(FileFormatVersions.Office2016);
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the StringDataType class.
    /// </summary>
    public StringDataType():base(){}
    
        /// <summary>
    ///Initializes a new instance of the StringDataType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public StringDataType(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the StringDataType class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public StringDataType(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the StringDataType class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public StringDataType(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "ptCount" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.PointCount();
    
if( 11 == namespaceId && "pt" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.StringPoint();
    
if( 11 == namespaceId && "extLst" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.StrDataExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "ptCount","pt","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> PointCount.</para>
    /// <para> Represents the following element tag in the schema: c:ptCount </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.PointCount PointCount
    {
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.PointCount>(0);
        set => SetElement(0, value);
    }


    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<StringDataType>(deep);

}
/// <summary>
/// <para>Defines the StrFilteredLiteralCache Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c16:filteredLitCache.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>StringDataType &lt;c16:strCache></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(StringDataType), FileFormatVersions.Office2016)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class StrFilteredLiteralCache : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13532;
    /// <inheritdoc/>
    public override string LocalName => "filteredLitCache";
    
    internal override byte NamespaceId => 82;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override bool IsInVersion(FileFormatVersions version) => version.AtLeast(FileFormatVersions.Office2016);
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the StrFilteredLiteralCache class.
    /// </summary>
    public StrFilteredLiteralCache():base(){}
    
        /// <summary>
    ///Initializes a new instance of the StrFilteredLiteralCache class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public StrFilteredLiteralCache(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the StrFilteredLiteralCache class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public StrFilteredLiteralCache(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the StrFilteredLiteralCache class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public StrFilteredLiteralCache(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 82 == namespaceId && "strCache" == name)
    return new StringDataType();
    

    return null;
}

        private static readonly string[] eleTagNames = { "strCache" };
    private static readonly byte[] eleNamespaceIds = { 82 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> StringDataType.</para>
    /// <para> Represents the following element tag in the schema: c16:strCache </para>
    /// </summary>
    /// <remark>
    /// xmlns:c16 = http://schemas.microsoft.com/office/drawing/2014/chart
    /// </remark>
    public StringDataType StringDataType
    {
        get => GetElement<StringDataType>(0);
        set => SetElement(0, value);
    }


    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<StrFilteredLiteralCache>(deep);

}
/// <summary>
/// <para>Defines the MultiLvlStrData Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c16:multiLvlStrCache.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.PointCount &lt;c:ptCount></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.Level &lt;c:lvl></description></item>
///<item><description>DocumentFormat.OpenXml.Drawing.Charts.ExtensionList &lt;c:extLst></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.PointCount))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.Level))]
    [ChildElementInfo(typeof(DocumentFormat.OpenXml.Drawing.Charts.ExtensionList))]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class MultiLvlStrData : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13533;
    /// <inheritdoc/>
    public override string LocalName => "multiLvlStrCache";
    
    internal override byte NamespaceId => 82;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override bool IsInVersion(FileFormatVersions version) => version.AtLeast(FileFormatVersions.Office2016);
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the MultiLvlStrData class.
    /// </summary>
    public MultiLvlStrData():base(){}
    
        /// <summary>
    ///Initializes a new instance of the MultiLvlStrData class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public MultiLvlStrData(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the MultiLvlStrData class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public MultiLvlStrData(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the MultiLvlStrData class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public MultiLvlStrData(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 11 == namespaceId && "ptCount" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.PointCount();
    
if( 11 == namespaceId && "lvl" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.Level();
    
if( 11 == namespaceId && "extLst" == name)
    return new DocumentFormat.OpenXml.Drawing.Charts.ExtensionList();
    

    return null;
}

        private static readonly string[] eleTagNames = { "ptCount","lvl","extLst" };
    private static readonly byte[] eleNamespaceIds = { 11,11,11 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> PointCount.</para>
    /// <para> Represents the following element tag in the schema: c:ptCount </para>
    /// </summary>
    /// <remark>
    /// xmlns:c = http://schemas.openxmlformats.org/drawingml/2006/chart
    /// </remark>
    public DocumentFormat.OpenXml.Drawing.Charts.PointCount PointCount
    {
        get => GetElement<DocumentFormat.OpenXml.Drawing.Charts.PointCount>(0);
        set => SetElement(0, value);
    }


    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<MultiLvlStrData>(deep);

}
/// <summary>
/// <para>Defines the MultiLvlStrFilteredLiteralCache Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c16:filteredLitCache.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>MultiLvlStrData &lt;c16:multiLvlStrCache></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(MultiLvlStrData), FileFormatVersions.Office2016)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class MultiLvlStrFilteredLiteralCache : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13534;
    /// <inheritdoc/>
    public override string LocalName => "filteredLitCache";
    
    internal override byte NamespaceId => 82;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override bool IsInVersion(FileFormatVersions version) => version.AtLeast(FileFormatVersions.Office2016);
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the MultiLvlStrFilteredLiteralCache class.
    /// </summary>
    public MultiLvlStrFilteredLiteralCache():base(){}
    
        /// <summary>
    ///Initializes a new instance of the MultiLvlStrFilteredLiteralCache class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public MultiLvlStrFilteredLiteralCache(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the MultiLvlStrFilteredLiteralCache class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public MultiLvlStrFilteredLiteralCache(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the MultiLvlStrFilteredLiteralCache class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public MultiLvlStrFilteredLiteralCache(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 82 == namespaceId && "multiLvlStrCache" == name)
    return new MultiLvlStrData();
    

    return null;
}

        private static readonly string[] eleTagNames = { "multiLvlStrCache" };
    private static readonly byte[] eleNamespaceIds = { 82 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> MultiLvlStrData.</para>
    /// <para> Represents the following element tag in the schema: c16:multiLvlStrCache </para>
    /// </summary>
    /// <remark>
    /// xmlns:c16 = http://schemas.microsoft.com/office/drawing/2014/chart
    /// </remark>
    public MultiLvlStrData MultiLvlStrData
    {
        get => GetElement<MultiLvlStrData>(0);
        set => SetElement(0, value);
    }


    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<MultiLvlStrFilteredLiteralCache>(deep);

}
/// <summary>
/// <para>Defines the LiteralDataChart Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c16:literalDataChart.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class LiteralDataChart : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13535;
    /// <inheritdoc/>
    public override string LocalName => "literalDataChart";
    
    internal override byte NamespaceId => 82;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override bool IsInVersion(FileFormatVersions version) => version.AtLeast(FileFormatVersions.Office2016);
    

    	private static readonly string[] attributeTagNames = { "val" };
    private static readonly byte[] attributeNamespaceIds = { 0 };
    
    internal override string[] AttributeTagNames => attributeTagNames;
    
    internal override byte[] AttributeNamespaceIds => attributeNamespaceIds;
    

    
        /// <summary>
    /// <para> val.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public BooleanValue Val
    {
        get { return (BooleanValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the LiteralDataChart class.
    /// </summary>
    public LiteralDataChart():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "val" == name)
    return new BooleanValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<LiteralDataChart>(deep);

}
/// <summary>
/// <para>Defines the BooleanFalse Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c16:showExpandCollapseFieldButtons.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class BooleanFalse : OpenXmlLeafElement
{
    internal const int ElementTypeIdConst = 13536;
    /// <inheritdoc/>
    public override string LocalName => "showExpandCollapseFieldButtons";
    
    internal override byte NamespaceId => 82;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override bool IsInVersion(FileFormatVersions version) => version.AtLeast(FileFormatVersions.Office2016);
    

    	private static readonly string[] attributeTagNames = { "val" };
    private static readonly byte[] attributeNamespaceIds = { 0 };
    
    internal override string[] AttributeTagNames => attributeTagNames;
    
    internal override byte[] AttributeNamespaceIds => attributeNamespaceIds;
    

    
        /// <summary>
    /// <para> val.</para>
    /// <para>Represents the following attribute in the schema: val </para>
    /// </summary>
    [SchemaAttr(0, "val")]
    public BooleanValue Val
    {
        get { return (BooleanValue)Attributes[0]; }
        set { Attributes[0] = value; }
    }
    

    /// <summary>
    /// Initializes a new instance of the BooleanFalse class.
    /// </summary>
    public BooleanFalse():base(){}
    
      
     
    
    
    
    internal override OpenXmlSimpleType AttributeFactory(byte namespaceId, string name)
{
    if( 0 == namespaceId && "val" == name)
    return new BooleanValue();
    

    
    return base.AttributeFactory(namespaceId, name);
}

    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<BooleanFalse>(deep);

}
/// <summary>
/// <para>Defines the XsdunsignedInt Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c16:ptidx.</para>
/// </summary>

[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class XsdunsignedInt : OpenXmlLeafTextElement
{
    internal const int ElementTypeIdConst = 13537;
    /// <inheritdoc/>
    public override string LocalName => "ptidx";
    
    internal override byte NamespaceId => 82;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override bool IsInVersion(FileFormatVersions version) => version.AtLeast(FileFormatVersions.Office2016);
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the XsdunsignedInt class.
    /// </summary>
    public XsdunsignedInt():base(){}
    
      
        /// <summary>
    /// Initializes a new instance of the XsdunsignedInt class with the specified text content.
    /// </summary>
    /// <param name="text">Specifies the text content of the element.</param>
    public XsdunsignedInt(string text):base(text)
    {
    }
    
    internal override OpenXmlSimpleType InnerTextToValue(string text)
    {
		return new UInt32Value(){ InnerText = text };
    }
    
 
    
    
    
    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<XsdunsignedInt>(deep);

}
/// <summary>
/// <para>Defines the ChartDataPointUniqueIDMapEntry Class.</para>
/// <para>This class is available in Office 2016 or above.</para>
/// <para> When the object is serialized out as xml, its qualified name is c16:ptentry.</para>
/// </summary>
/// <remarks>
/// The following table lists the possible child types:
/// <list type="bullet">
///<item><description>XsdunsignedInt &lt;c16:ptidx></description></item>
///<item><description>UniqueID &lt;c16:uniqueID></description></item>
/// </list>
/// </remarks>

    [ChildElementInfo(typeof(XsdunsignedInt), FileFormatVersions.Office2016)]
    [ChildElementInfo(typeof(UniqueID), FileFormatVersions.Office2016)]
[System.CodeDom.Compiler.GeneratedCode("DomGen", "3.0")]
[OfficeAvailability(FileFormatVersions.Office2016)]
public partial class ChartDataPointUniqueIDMapEntry : OpenXmlCompositeElement
{
    internal const int ElementTypeIdConst = 13539;
    /// <inheritdoc/>
    public override string LocalName => "ptentry";
    
    internal override byte NamespaceId => 82;
    
    internal override int ElementTypeId => ElementTypeIdConst;
   
    internal override bool IsInVersion(FileFormatVersions version) => version.AtLeast(FileFormatVersions.Office2016);
    

    
    
    
    /// <summary>
    /// Initializes a new instance of the ChartDataPointUniqueIDMapEntry class.
    /// </summary>
    public ChartDataPointUniqueIDMapEntry():base(){}
    
        /// <summary>
    ///Initializes a new instance of the ChartDataPointUniqueIDMapEntry class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ChartDataPointUniqueIDMapEntry(System.Collections.Generic.IEnumerable<OpenXmlElement> childElements)
        : base(childElements)
    { 
    }
    
    /// <summary>
    /// Initializes a new instance of the ChartDataPointUniqueIDMapEntry class with the specified child elements.
    /// </summary>
    /// <param name="childElements">Specifies the child elements.</param>
    public ChartDataPointUniqueIDMapEntry(params OpenXmlElement[] childElements) : base(childElements)
    {
    }
    
    /// <summary>
    /// Initializes a new instance of the ChartDataPointUniqueIDMapEntry class from outer XML.
    /// </summary>
    /// <param name="outerXml">Specifies the outer XML of the element.</param>
    public ChartDataPointUniqueIDMapEntry(string outerXml)
        : base(outerXml)
    {
    }
  
     
    
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
internal override OpenXmlElement ElementFactory(byte namespaceId, string name)
{
    if( 82 == namespaceId && "ptidx" == name)
    return new XsdunsignedInt();
    
if( 82 == namespaceId && "uniqueID" == name)
    return new UniqueID();
    

    return null;
}

        private static readonly string[] eleTagNames = { "ptidx","uniqueID" };
    private static readonly byte[] eleNamespaceIds = { 82,82 };
    
    internal override string[] ElementTagNames => eleTagNames;
    
    internal override byte[] ElementNamespaceIds => eleNamespaceIds;
    internal override OpenXmlCompositeType OpenXmlCompositeType => OpenXmlCompositeType.OneSequence;
    
        /// <summary>
    /// <para> XsdunsignedInt.</para>
    /// <para> Represents the following element tag in the schema: c16:ptidx </para>
    /// </summary>
    /// <remark>
    /// xmlns:c16 = http://schemas.microsoft.com/office/drawing/2014/chart
    /// </remark>
    public XsdunsignedInt XsdunsignedInt
    {
        get => GetElement<XsdunsignedInt>(0);
        set => SetElement(0, value);
    }
    /// <summary>
    /// <para> UniqueID.</para>
    /// <para> Represents the following element tag in the schema: c16:uniqueID </para>
    /// </summary>
    /// <remark>
    /// xmlns:c16 = http://schemas.microsoft.com/office/drawing/2014/chart
    /// </remark>
    public UniqueID UniqueID
    {
        get => GetElement<UniqueID>(1);
        set => SetElement(1, value);
    }


    
    /// <inheritdoc/>
    public override OpenXmlElement CloneNode(bool deep) => CloneImp<ChartDataPointUniqueIDMapEntry>(deep);

}
}
 
 
