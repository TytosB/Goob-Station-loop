// SPDX-FileCopyrightText: 2024 Aiden <aiden@djkraz.com>
// SPDX-FileCopyrightText: 2024 Fishbait <Fishbait@git.ml>
// SPDX-FileCopyrightText: 2024 fishbait <gnesse@gmail.com>
// SPDX-FileCopyrightText: 2025 Aiden <28298836+Aidenkrz@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 Misandry <mary@thughunt.ing>
// SPDX-FileCopyrightText: 2025 gus <august.eymann@gmail.com>
//
// SPDX-License-Identifier: AGPL-3.0-or-later

using Robust.Shared.Network;
using Robust.Shared.Serialization;

namespace Content.Goobstation.Shared.Blob.Events;

[Serializable, NetSerializable]
public sealed partial class CreateBlobObserverEvent : CancellableEntityEventArgs
{
    public NetUserId UserId { get; private set; }

    public CreateBlobObserverEvent(NetUserId userId)
    {
        UserId = userId;
    }
}