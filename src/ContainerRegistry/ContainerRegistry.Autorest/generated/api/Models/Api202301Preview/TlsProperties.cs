// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Extensions;

    /// <summary>The TLS properties of the connected registry login server.</summary>
    public partial class TlsProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.ITlsProperties,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.ITlsPropertiesInternal
    {

        /// <summary>Backing field for <see cref="Certificate" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.ITlsCertificateProperties _certificate;

        /// <summary>The certificate used to configure HTTPS for the login server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.ITlsCertificateProperties Certificate { get => (this._certificate = this._certificate ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.TlsCertificateProperties()); }

        /// <summary>Indicates the location of the certificates.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public string CertificateLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.ITlsCertificatePropertiesInternal)Certificate).Location; }

        /// <summary>The type of certificate location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.CertificateType? CertificateType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.ITlsCertificatePropertiesInternal)Certificate).Type; }

        /// <summary>Internal Acessors for Certificate</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.ITlsCertificateProperties Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.ITlsPropertiesInternal.Certificate { get => (this._certificate = this._certificate ?? new Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.TlsCertificateProperties()); set { {_certificate = value;} } }

        /// <summary>Internal Acessors for CertificateLocation</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.ITlsPropertiesInternal.CertificateLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.ITlsCertificatePropertiesInternal)Certificate).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.ITlsCertificatePropertiesInternal)Certificate).Location = value; }

        /// <summary>Internal Acessors for CertificateType</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.CertificateType? Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.ITlsPropertiesInternal.CertificateType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.ITlsCertificatePropertiesInternal)Certificate).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.ITlsCertificatePropertiesInternal)Certificate).Type = value; }

        /// <summary>Internal Acessors for Status</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TlsStatus? Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.ITlsPropertiesInternal.Status { get => this._status; set { {_status = value;} } }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TlsStatus? _status;

        /// <summary>Indicates whether HTTPS is enabled for the login server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TlsStatus? Status { get => this._status; }

        /// <summary>Creates an new <see cref="TlsProperties" /> instance.</summary>
        public TlsProperties()
        {

        }
    }
    /// The TLS properties of the connected registry login server.
    public partial interface ITlsProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.IJsonSerializable
    {
        /// <summary>Indicates the location of the certificates.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Indicates the location of the certificates.",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        string CertificateLocation { get;  }
        /// <summary>The type of certificate location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The type of certificate location.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.CertificateType) })]
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.CertificateType? CertificateType { get;  }
        /// <summary>Indicates whether HTTPS is enabled for the login server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Indicates whether HTTPS is enabled for the login server.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TlsStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TlsStatus? Status { get;  }

    }
    /// The TLS properties of the connected registry login server.
    internal partial interface ITlsPropertiesInternal

    {
        /// <summary>The certificate used to configure HTTPS for the login server.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.ITlsCertificateProperties Certificate { get; set; }
        /// <summary>Indicates the location of the certificates.</summary>
        string CertificateLocation { get; set; }
        /// <summary>The type of certificate location.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.CertificateType? CertificateType { get; set; }
        /// <summary>Indicates whether HTTPS is enabled for the login server.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TlsStatus? Status { get; set; }

    }
}