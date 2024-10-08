// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Describes a Virtual Machine Scale Set.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class VirtualMachineScaleSetUpdate : UpdateResource
    {
        /// <summary>
        /// Initializes a new instance of the VirtualMachineScaleSetUpdate
        /// class.
        /// </summary>
        public VirtualMachineScaleSetUpdate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VirtualMachineScaleSetUpdate
        /// class.
        /// </summary>
        /// <param name="tags">Resource tags</param>
        /// <param name="sku">The virtual machine scale set sku.</param>
        /// <param name="plan">The purchase plan when deploying a virtual
        /// machine scale set from VM Marketplace images.</param>
        /// <param name="upgradePolicy">The upgrade policy.</param>
        /// <param name="automaticRepairsPolicy">Policy for automatic
        /// repairs.</param>
        /// <param name="virtualMachineProfile">The virtual machine
        /// profile.</param>
        /// <param name="overprovision">Specifies whether the Virtual Machine
        /// Scale Set should be overprovisioned.</param>
        /// <param name="doNotRunExtensionsOnOverprovisionedVMs">When
        /// Overprovision is enabled, extensions are launched only on the
        /// requested number of VMs which are finally kept. This property will
        /// hence ensure that the extensions do not run on the extra
        /// overprovisioned VMs.</param>
        /// <param name="singlePlacementGroup">When true this limits the scale
        /// set to a single placement group, of max size 100 virtual machines.
        /// NOTE: If singlePlacementGroup is true, it may be modified to false.
        /// However, if singlePlacementGroup is false, it may not be modified
        /// to true.</param>
        /// <param name="additionalCapabilities">Specifies additional
        /// capabilities enabled or disabled on the Virtual Machines in the
        /// Virtual Machine Scale Set. For instance: whether the Virtual
        /// Machines have the capability to support attaching managed data
        /// disks with UltraSSD_LRS storage account type.</param>
        /// <param name="scaleInPolicy">Specifies the policies applied when
        /// scaling in Virtual Machines in the Virtual Machine Scale
        /// Set.</param>
        /// <param name="proximityPlacementGroup">Specifies information about
        /// the proximity placement group that the virtual machine scale set
        /// should be assigned to. &lt;br&gt;&lt;br&gt;Minimum api-version:
        /// 2018-04-01.</param>
        /// <param name="priorityMixPolicy">Specifies the desired targets for
        /// mixing Spot and Regular priority VMs within the same VMSS Flex
        /// instance.</param>
        /// <param name="spotRestorePolicy">Specifies the Spot Restore
        /// properties for the virtual machine scale set.</param>
        /// <param name="resiliencyPolicy">Policy for Resiliency</param>
        /// <param name="zonalPlatformFaultDomainAlignMode">Specifies the align
        /// mode between Virtual Machine Scale Set compute and storage Fault
        /// Domain count. Possible values include: 'Aligned',
        /// 'Unaligned'</param>
        /// <param name="skuProfile">Specifies the sku profile for the virtual
        /// machine scale set.</param>
        /// <param name="identity">The identity of the virtual machine scale
        /// set, if configured.</param>
        /// <param name="zones">The virtual machine scale set zones.</param>
        public VirtualMachineScaleSetUpdate(IDictionary<string, string> tags = default(IDictionary<string, string>), Sku sku = default(Sku), Plan plan = default(Plan), UpgradePolicy upgradePolicy = default(UpgradePolicy), AutomaticRepairsPolicy automaticRepairsPolicy = default(AutomaticRepairsPolicy), VirtualMachineScaleSetUpdateVMProfile virtualMachineProfile = default(VirtualMachineScaleSetUpdateVMProfile), bool? overprovision = default(bool?), bool? doNotRunExtensionsOnOverprovisionedVMs = default(bool?), bool? singlePlacementGroup = default(bool?), AdditionalCapabilities additionalCapabilities = default(AdditionalCapabilities), ScaleInPolicy scaleInPolicy = default(ScaleInPolicy), SubResource proximityPlacementGroup = default(SubResource), PriorityMixPolicy priorityMixPolicy = default(PriorityMixPolicy), SpotRestorePolicy spotRestorePolicy = default(SpotRestorePolicy), ResiliencyPolicy resiliencyPolicy = default(ResiliencyPolicy), string zonalPlatformFaultDomainAlignMode = default(string), SkuProfile skuProfile = default(SkuProfile), VirtualMachineScaleSetIdentity identity = default(VirtualMachineScaleSetIdentity), IList<string> zones = default(IList<string>))
            : base(tags)
        {
            Sku = sku;
            Plan = plan;
            UpgradePolicy = upgradePolicy;
            AutomaticRepairsPolicy = automaticRepairsPolicy;
            VirtualMachineProfile = virtualMachineProfile;
            Overprovision = overprovision;
            DoNotRunExtensionsOnOverprovisionedVMs = doNotRunExtensionsOnOverprovisionedVMs;
            SinglePlacementGroup = singlePlacementGroup;
            AdditionalCapabilities = additionalCapabilities;
            ScaleInPolicy = scaleInPolicy;
            ProximityPlacementGroup = proximityPlacementGroup;
            PriorityMixPolicy = priorityMixPolicy;
            SpotRestorePolicy = spotRestorePolicy;
            ResiliencyPolicy = resiliencyPolicy;
            ZonalPlatformFaultDomainAlignMode = zonalPlatformFaultDomainAlignMode;
            SkuProfile = skuProfile;
            Identity = identity;
            Zones = zones;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the virtual machine scale set sku.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public Sku Sku { get; set; }

        /// <summary>
        /// Gets or sets the purchase plan when deploying a virtual machine
        /// scale set from VM Marketplace images.
        /// </summary>
        [JsonProperty(PropertyName = "plan")]
        public Plan Plan { get; set; }

        /// <summary>
        /// Gets or sets the upgrade policy.
        /// </summary>
        [JsonProperty(PropertyName = "properties.upgradePolicy")]
        public UpgradePolicy UpgradePolicy { get; set; }

        /// <summary>
        /// Gets or sets policy for automatic repairs.
        /// </summary>
        [JsonProperty(PropertyName = "properties.automaticRepairsPolicy")]
        public AutomaticRepairsPolicy AutomaticRepairsPolicy { get; set; }

        /// <summary>
        /// Gets or sets the virtual machine profile.
        /// </summary>
        [JsonProperty(PropertyName = "properties.virtualMachineProfile")]
        public VirtualMachineScaleSetUpdateVMProfile VirtualMachineProfile { get; set; }

        /// <summary>
        /// Gets or sets specifies whether the Virtual Machine Scale Set should
        /// be overprovisioned.
        /// </summary>
        [JsonProperty(PropertyName = "properties.overprovision")]
        public bool? Overprovision { get; set; }

        /// <summary>
        /// Gets or sets when Overprovision is enabled, extensions are launched
        /// only on the requested number of VMs which are finally kept. This
        /// property will hence ensure that the extensions do not run on the
        /// extra overprovisioned VMs.
        /// </summary>
        [JsonProperty(PropertyName = "properties.doNotRunExtensionsOnOverprovisionedVMs")]
        public bool? DoNotRunExtensionsOnOverprovisionedVMs { get; set; }

        /// <summary>
        /// Gets or sets when true this limits the scale set to a single
        /// placement group, of max size 100 virtual machines. NOTE: If
        /// singlePlacementGroup is true, it may be modified to false. However,
        /// if singlePlacementGroup is false, it may not be modified to true.
        /// </summary>
        [JsonProperty(PropertyName = "properties.singlePlacementGroup")]
        public bool? SinglePlacementGroup { get; set; }

        /// <summary>
        /// Gets or sets specifies additional capabilities enabled or disabled
        /// on the Virtual Machines in the Virtual Machine Scale Set. For
        /// instance: whether the Virtual Machines have the capability to
        /// support attaching managed data disks with UltraSSD_LRS storage
        /// account type.
        /// </summary>
        [JsonProperty(PropertyName = "properties.additionalCapabilities")]
        public AdditionalCapabilities AdditionalCapabilities { get; set; }

        /// <summary>
        /// Gets or sets specifies the policies applied when scaling in Virtual
        /// Machines in the Virtual Machine Scale Set.
        /// </summary>
        [JsonProperty(PropertyName = "properties.scaleInPolicy")]
        public ScaleInPolicy ScaleInPolicy { get; set; }

        /// <summary>
        /// Gets or sets specifies information about the proximity placement
        /// group that the virtual machine scale set should be assigned to.
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt;Minimum api-version:
        /// 2018-04-01.
        /// </summary>
        [JsonProperty(PropertyName = "properties.proximityPlacementGroup")]
        public SubResource ProximityPlacementGroup { get; set; }

        /// <summary>
        /// Gets or sets specifies the desired targets for mixing Spot and
        /// Regular priority VMs within the same VMSS Flex instance.
        /// </summary>
        [JsonProperty(PropertyName = "properties.priorityMixPolicy")]
        public PriorityMixPolicy PriorityMixPolicy { get; set; }

        /// <summary>
        /// Gets or sets specifies the Spot Restore properties for the virtual
        /// machine scale set.
        /// </summary>
        [JsonProperty(PropertyName = "properties.spotRestorePolicy")]
        public SpotRestorePolicy SpotRestorePolicy { get; set; }

        /// <summary>
        /// Gets or sets policy for Resiliency
        /// </summary>
        [JsonProperty(PropertyName = "properties.resiliencyPolicy")]
        public ResiliencyPolicy ResiliencyPolicy { get; set; }

        /// <summary>
        /// Gets or sets specifies the align mode between Virtual Machine Scale
        /// Set compute and storage Fault Domain count. Possible values
        /// include: 'Aligned', 'Unaligned'
        /// </summary>
        [JsonProperty(PropertyName = "properties.zonalPlatformFaultDomainAlignMode")]
        public string ZonalPlatformFaultDomainAlignMode { get; set; }

        /// <summary>
        /// Gets or sets specifies the sku profile for the virtual machine
        /// scale set.
        /// </summary>
        [JsonProperty(PropertyName = "properties.skuProfile")]
        public SkuProfile SkuProfile { get; set; }

        /// <summary>
        /// Gets or sets the identity of the virtual machine scale set, if
        /// configured.
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public VirtualMachineScaleSetIdentity Identity { get; set; }

        /// <summary>
        /// Gets or sets the virtual machine scale set zones.
        /// </summary>
        [JsonProperty(PropertyName = "zones")]
        public IList<string> Zones { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (UpgradePolicy != null)
            {
                UpgradePolicy.Validate();
            }
            if (PriorityMixPolicy != null)
            {
                PriorityMixPolicy.Validate();
            }
        }
    }
}
