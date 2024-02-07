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
	public class Medicare_Exempt_DataType : INotifyPropertyChanged
	{
		private bool exempt_from_MedicareField;

		private bool exempt_from_MedicareFieldSpecified;

		private Payroll_Payee_FICA_Exempt_ReasonObjectType[] medicare_Reason_for_Exemption_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Exempt_from_Medicare
		{
			get
			{
				return this.exempt_from_MedicareField;
			}
			set
			{
				this.exempt_from_MedicareField = value;
				this.RaisePropertyChanged("Exempt_from_Medicare");
			}
		}

		[XmlIgnore]
		public bool Exempt_from_MedicareSpecified
		{
			get
			{
				return this.exempt_from_MedicareFieldSpecified;
			}
			set
			{
				this.exempt_from_MedicareFieldSpecified = value;
				this.RaisePropertyChanged("Exempt_from_MedicareSpecified");
			}
		}

		[XmlElement("Medicare_Reason_for_Exemption_Reference", Order = 1)]
		public Payroll_Payee_FICA_Exempt_ReasonObjectType[] Medicare_Reason_for_Exemption_Reference
		{
			get
			{
				return this.medicare_Reason_for_Exemption_ReferenceField;
			}
			set
			{
				this.medicare_Reason_for_Exemption_ReferenceField = value;
				this.RaisePropertyChanged("Medicare_Reason_for_Exemption_Reference");
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
