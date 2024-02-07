using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll.Can
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName = "RL-1_Contact_InformationType", Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class RL1_Contact_InformationType : INotifyPropertyChanged
	{
		private string rL1_Contact_NameField;

		private string rL1_Contact_Phone_NumberField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("RL-1_Contact_Name", Order = 0)]
		public string RL1_Contact_Name
		{
			get
			{
				return this.rL1_Contact_NameField;
			}
			set
			{
				this.rL1_Contact_NameField = value;
				this.RaisePropertyChanged("RL1_Contact_Name");
			}
		}

		[XmlElement("RL-1_Contact_Phone_Number", Order = 1)]
		public string RL1_Contact_Phone_Number
		{
			get
			{
				return this.rL1_Contact_Phone_NumberField;
			}
			set
			{
				this.rL1_Contact_Phone_NumberField = value;
				this.RaisePropertyChanged("RL1_Contact_Phone_Number");
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
