using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Effort_Certification_Change_Reason_Code_DataType : INotifyPropertyChanged
	{
		private string effort_Certification_Change_Reason_Code_IDField;

		private string effort_Certification_Change_Reason_Code_NameField;

		private bool effort_Certification_Change_Reason_Code_Is_CostedField;

		private bool effort_Certification_Change_Reason_Code_Is_CostedFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Effort_Certification_Change_Reason_Code_ID
		{
			get
			{
				return this.effort_Certification_Change_Reason_Code_IDField;
			}
			set
			{
				this.effort_Certification_Change_Reason_Code_IDField = value;
				this.RaisePropertyChanged("Effort_Certification_Change_Reason_Code_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Effort_Certification_Change_Reason_Code_Name
		{
			get
			{
				return this.effort_Certification_Change_Reason_Code_NameField;
			}
			set
			{
				this.effort_Certification_Change_Reason_Code_NameField = value;
				this.RaisePropertyChanged("Effort_Certification_Change_Reason_Code_Name");
			}
		}

		[XmlElement(Order = 2)]
		public bool Effort_Certification_Change_Reason_Code_Is_Costed
		{
			get
			{
				return this.effort_Certification_Change_Reason_Code_Is_CostedField;
			}
			set
			{
				this.effort_Certification_Change_Reason_Code_Is_CostedField = value;
				this.RaisePropertyChanged("Effort_Certification_Change_Reason_Code_Is_Costed");
			}
		}

		[XmlIgnore]
		public bool Effort_Certification_Change_Reason_Code_Is_CostedSpecified
		{
			get
			{
				return this.effort_Certification_Change_Reason_Code_Is_CostedFieldSpecified;
			}
			set
			{
				this.effort_Certification_Change_Reason_Code_Is_CostedFieldSpecified = value;
				this.RaisePropertyChanged("Effort_Certification_Change_Reason_Code_Is_CostedSpecified");
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
