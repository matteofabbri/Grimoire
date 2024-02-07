using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Talent
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Certification_Response_GroupType : INotifyPropertyChanged
	{
		private bool include_ReferenceField;

		private bool include_ReferenceFieldSpecified;

		private bool include_Certification_Issuer_Reference_OnlyField;

		private bool include_Certification_Issuer_Reference_OnlyFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Include_Reference
		{
			get
			{
				return this.include_ReferenceField;
			}
			set
			{
				this.include_ReferenceField = value;
				this.RaisePropertyChanged("Include_Reference");
			}
		}

		[XmlIgnore]
		public bool Include_ReferenceSpecified
		{
			get
			{
				return this.include_ReferenceFieldSpecified;
			}
			set
			{
				this.include_ReferenceFieldSpecified = value;
				this.RaisePropertyChanged("Include_ReferenceSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public bool Include_Certification_Issuer_Reference_Only
		{
			get
			{
				return this.include_Certification_Issuer_Reference_OnlyField;
			}
			set
			{
				this.include_Certification_Issuer_Reference_OnlyField = value;
				this.RaisePropertyChanged("Include_Certification_Issuer_Reference_Only");
			}
		}

		[XmlIgnore]
		public bool Include_Certification_Issuer_Reference_OnlySpecified
		{
			get
			{
				return this.include_Certification_Issuer_Reference_OnlyFieldSpecified;
			}
			set
			{
				this.include_Certification_Issuer_Reference_OnlyFieldSpecified = value;
				this.RaisePropertyChanged("Include_Certification_Issuer_Reference_OnlySpecified");
			}
		}

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
