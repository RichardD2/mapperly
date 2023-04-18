﻿//HintName: Mapper.g.cs
#nullable enable
public partial class Mapper
{
    private partial global::B MapToB(global::A source)
    {
        return MapToB2(source, new global::Riok.Mapperly.Abstractions.ReferenceHandling.Internal.PreserveReferenceHandler());
    }

    private partial global::B MapToB1(global::A source)
    {
        return MapToB3(source, new global::Riok.Mapperly.Abstractions.ReferenceHandling.Internal.PreserveReferenceHandler());
    }

    private global::B MapToB2(global::A source, global::Riok.Mapperly.Abstractions.ReferenceHandling.IReferenceHandler refHandler)
    {
        if (refHandler.TryGetReference<global::A, global::B>(source, out var existingTargetReference))
            return existingTargetReference;
        var target = new global::B();
        refHandler.SetReference<global::A, global::B>(source, target);
        target.Parent = MapToB2(source.Parent, refHandler);
        target.MyValue = MapToD(source.Value, refHandler);
        return target;
    }

    private global::B MapToB3(global::A source, global::Riok.Mapperly.Abstractions.ReferenceHandling.IReferenceHandler refHandler)
    {
        if (refHandler.TryGetReference<global::A, global::B>(source, out var existingTargetReference))
            return existingTargetReference;
        var target = new global::B();
        refHandler.SetReference<global::A, global::B>(source, target);
        target.Parent = MapToB2(source.Parent, refHandler);
        target.MyValue2 = MapToD(source.Value, refHandler);
        return target;
    }

    private global::D MapToD(global::C source, global::Riok.Mapperly.Abstractions.ReferenceHandling.IReferenceHandler refHandler)
    {
        if (refHandler.TryGetReference<global::C, global::D>(source, out var existingTargetReference))
            return existingTargetReference;
        var target = new global::D();
        refHandler.SetReference<global::C, global::D>(source, target);
        target.StringValue = source.StringValue;
        return target;
    }
}