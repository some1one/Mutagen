using Mutagen.Bethesda.Plugins.Meta;
using Noggog;
using System.Buffers.Binary;

namespace Mutagen.Bethesda.Plugins.Binary.Headers;

/// <summary>
/// A ref struct that overlays on top of bytes that is able to retrieve basic header data on demand
/// utilizing a given constants object to define the lengths
/// </summary>
public readonly struct VariableHeader
{
    /// <summary>
    /// Bytes overlaid onto
    /// </summary>
    public ReadOnlyMemorySlice<byte> Span { get; }
        
    /// <summary>
    /// Record metadata to use as reference for alignment
    /// </summary>
    public RecordHeaderConstants Constants { get; }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="constants">Record constants to use as reference for alignment</param>
    /// <param name="span">Span to overlay on, aligned to the start of the header</param>
    public VariableHeader(RecordHeaderConstants constants, ReadOnlyMemorySlice<byte> span)
    {
        Constants = constants;
        Span = span.Slice(0, constants.HeaderLength);
    }

    /// <summary>
    /// The length that the header itself takes
    /// </summary>
    public byte HeaderLength => Constants.HeaderLength;
        
    public int RecordTypeInt => BinaryPrimitives.ReadInt32LittleEndian(Span.Slice(0, 4));
        
    /// <summary>
    /// RecordType of the header
    /// </summary>
    public RecordType RecordType => new(RecordTypeInt);
        
    private uint RecordLength
    {
        get
        {
            switch (Constants.LengthLength)
            {
                case 1:
                    return Span[4];
                case 2:
                    return BinaryPrimitives.ReadUInt16LittleEndian(Span.Slice(4, 2));
                case 4:
                    return BinaryPrimitives.ReadUInt32LittleEndian(Span.Slice(4, 4));
                default:
                    throw new NotImplementedException();
            }
        }
    }
        
    /// <summary>
    /// The length of the RecordType and the length bytes
    /// </summary>
    public int TypeAndLengthLength => Constants.TypeAndLengthLength;
        
    /// <summary>
    /// Total length of the record, including the header and its content.
    /// </summary>
    public long TotalLength => Constants.HeaderIncludedInLength ? RecordLength : (HeaderLength + RecordLength);
        
    /// <summary>
    /// True if RecordType == "GRUP"
    /// </summary>
    public bool IsGroup => Constants.ObjectType == ObjectType.Group;
        
    /// <summary>
    /// The length of the content, excluding the header bytes.
    /// </summary>
    public long ContentLength => Constants.HeaderIncludedInLength ? RecordLength - HeaderLength : RecordLength;

    /// <inheritdoc/>
    public override string ToString() => $"{RecordType} [0x{ContentLength:X}]";
}