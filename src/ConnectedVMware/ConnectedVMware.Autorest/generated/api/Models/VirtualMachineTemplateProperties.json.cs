// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Extensions;

    /// <summary>Describes the properties of a Virtual Machine Template.</summary>
    public partial class VirtualMachineTemplateProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.IVirtualMachineTemplateProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.IVirtualMachineTemplateProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.IVirtualMachineTemplateProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonObject json ? new VirtualMachineTemplateProperties(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="VirtualMachineTemplateProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="VirtualMachineTemplateProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._uuid)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonString(this._uuid.ToString()) : null, "uuid" ,container.Add );
            }
            AddIf( null != (((object)this._vCenterId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonString(this._vCenterId.ToString()) : null, "vCenterId" ,container.Add );
            AddIf( null != (((object)this._moRefId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonString(this._moRefId.ToString()) : null, "moRefId" ,container.Add );
            AddIf( null != (((object)this._inventoryItemId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonString(this._inventoryItemId.ToString()) : null, "inventoryItemId" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._moName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonString(this._moName.ToString()) : null, "moName" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != this._memorySizeMb ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonNumber((int)this._memorySizeMb) : null, "memorySizeMB" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != this._numCpUs ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonNumber((int)this._numCpUs) : null, "numCPUs" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != this._numCoresPerSocket ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonNumber((int)this._numCoresPerSocket) : null, "numCoresPerSocket" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._oSType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonString(this._oSType.ToString()) : null, "osType" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._oSName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonString(this._oSName.ToString()) : null, "osName" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._folderPath)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonString(this._folderPath.ToString()) : null, "folderPath" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.SerializationMode.IncludeRead))
            {
                if (null != this._networkInterface)
                {
                    var __w = new Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.XNodeArray();
                    foreach( var __x in this._networkInterface )
                    {
                        AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                    }
                    container.Add("networkInterfaces",__w);
                }
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.SerializationMode.IncludeRead))
            {
                if (null != this._disk)
                {
                    var __r = new Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.XNodeArray();
                    foreach( var __s in this._disk )
                    {
                        AddIf(__s?.ToJson(null, serializationMode) ,__r.Add);
                    }
                    container.Add("disks",__r);
                }
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._customResourceName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonString(this._customResourceName.ToString()) : null, "customResourceName" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._toolsVersionStatus)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonString(this._toolsVersionStatus.ToString()) : null, "toolsVersionStatus" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._toolsVersion)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonString(this._toolsVersion.ToString()) : null, "toolsVersion" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._firmwareType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonString(this._firmwareType.ToString()) : null, "firmwareType" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.SerializationMode.IncludeRead))
            {
                if (null != this._statuses)
                {
                    var __m = new Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.XNodeArray();
                    foreach( var __n in this._statuses )
                    {
                        AddIf(__n?.ToJson(null, serializationMode) ,__m.Add);
                    }
                    container.Add("statuses",__m);
                }
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._provisioningState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonString(this._provisioningState.ToString()) : null, "provisioningState" ,container.Add );
            }
            AfterToJson(ref container);
            return container;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonObject into a new instance of <see cref="VirtualMachineTemplateProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal VirtualMachineTemplateProperties(Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_uuid = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonString>("uuid"), out var __jsonUuid) ? (string)__jsonUuid : (string)_uuid;}
            {_vCenterId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonString>("vCenterId"), out var __jsonVCenterId) ? (string)__jsonVCenterId : (string)_vCenterId;}
            {_moRefId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonString>("moRefId"), out var __jsonMoRefId) ? (string)__jsonMoRefId : (string)_moRefId;}
            {_inventoryItemId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonString>("inventoryItemId"), out var __jsonInventoryItemId) ? (string)__jsonInventoryItemId : (string)_inventoryItemId;}
            {_moName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonString>("moName"), out var __jsonMoName) ? (string)__jsonMoName : (string)_moName;}
            {_memorySizeMb = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonNumber>("memorySizeMB"), out var __jsonMemorySizeMb) ? (int?)__jsonMemorySizeMb : _memorySizeMb;}
            {_numCpUs = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonNumber>("numCPUs"), out var __jsonNumCpUs) ? (int?)__jsonNumCpUs : _numCpUs;}
            {_numCoresPerSocket = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonNumber>("numCoresPerSocket"), out var __jsonNumCoresPerSocket) ? (int?)__jsonNumCoresPerSocket : _numCoresPerSocket;}
            {_oSType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonString>("osType"), out var __jsonOSType) ? (string)__jsonOSType : (string)_oSType;}
            {_oSName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonString>("osName"), out var __jsonOSName) ? (string)__jsonOSName : (string)_oSName;}
            {_folderPath = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonString>("folderPath"), out var __jsonFolderPath) ? (string)__jsonFolderPath : (string)_folderPath;}
            {_networkInterface = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonArray>("networkInterfaces"), out var __jsonNetworkInterfaces) ? If( __jsonNetworkInterfaces as Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.INetworkInterface>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.INetworkInterface) (Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.NetworkInterface.FromJson(__u) )) ))() : null : _networkInterface;}
            {_disk = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonArray>("disks"), out var __jsonDisks) ? If( __jsonDisks as Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.IVirtualDisk>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__q, (__p)=>(Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.IVirtualDisk) (Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.VirtualDisk.FromJson(__p) )) ))() : null : _disk;}
            {_customResourceName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonString>("customResourceName"), out var __jsonCustomResourceName) ? (string)__jsonCustomResourceName : (string)_customResourceName;}
            {_toolsVersionStatus = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonString>("toolsVersionStatus"), out var __jsonToolsVersionStatus) ? (string)__jsonToolsVersionStatus : (string)_toolsVersionStatus;}
            {_toolsVersion = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonString>("toolsVersion"), out var __jsonToolsVersion) ? (string)__jsonToolsVersion : (string)_toolsVersion;}
            {_firmwareType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonString>("firmwareType"), out var __jsonFirmwareType) ? (string)__jsonFirmwareType : (string)_firmwareType;}
            {_statuses = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonArray>("statuses"), out var __jsonStatuses) ? If( __jsonStatuses as Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonArray, out var __l) ? new global::System.Func<System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.IResourceStatus>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__l, (__k)=>(Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.IResourceStatus) (Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.ResourceStatus.FromJson(__k) )) ))() : null : _statuses;}
            {_provisioningState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Json.JsonString>("provisioningState"), out var __jsonProvisioningState) ? (string)__jsonProvisioningState : (string)_provisioningState;}
            AfterFromJson(json);
        }
    }
}