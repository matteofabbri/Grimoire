using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class OASDI_Exempt_DataType : INotifyPropertyChanged
	{
		private bool exempt_from_OASDIField;

		private bool exempt_from_OASDIFieldSpecified;

		private Payroll_Payee_FICA_Exempt_ReasonObjectType[] oASDI_Reason_for_Exemption_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Exempt_from_OASDI
		{
			get
			{
				return this.exempt_from_OASDIField;
			}
			set
			{
				this.exempt_from_OASDIField = value;
				this.RaisePropertyChanged("Exempt_from_OASDI");
			}
		}

		[XmlIgnore]
		public bool Exempt_from_OASDISpecified
		{
			get
			{
				return this.exempt_from_OASDIFieldSpecified;
			}
			set
			{
				this.exempt_from_OASDIFieldSpecified = value;
				this.RaisePropertyChanged("Exempt_from_OASDISpecified");
			}
		}

		[XmlElement("OASDI_Reason_for_Exemption_Reference", Order = 1)]
		public Payroll_Payee_FICA_Exempt_ReasonObjectType[] OASDI_Reason_for_Exemption_Reference
		{
			get
			{
				return this.oASDI_Reason_for_Exemption_ReferenceField;
			}
			set
			{
				this.oASDI_Reason_for_Exemption_ReferenceField = value;
				this.RaisePropertyChanged("OASDI_Reason_for_Exemption_Reference");
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
