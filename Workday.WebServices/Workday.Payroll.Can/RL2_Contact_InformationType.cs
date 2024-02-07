using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll.Can
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName = "RL-2_Contact_InformationType", Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class RL2_Contact_InformationType : INotifyPropertyChanged
	{
		private string rL2_Contact_NameField;

		private string rL2_Contact_Phone_NumberField;

		private string rL2_Contact_Language_of_CommunicationField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("RL-2_Contact_Name", Order = 0)]
		public string RL2_Contact_Name
		{
			get
			{
				return this.rL2_Contact_NameField;
			}
			set
			{
				this.rL2_Contact_NameField = value;
				this.RaisePropertyChanged("RL2_Contact_Name");
			}
		}

		[XmlElement("RL-2_Contact_Phone_Number", Order = 1)]
		public string RL2_Contact_Phone_Number
		{
			get
			{
				return this.rL2_Contact_Phone_NumberField;
			}
			set
			{
				this.rL2_Contact_Phone_NumberField = value;
				this.RaisePropertyChanged("RL2_Contact_Phone_Number");
			}
		}

		[XmlElement("RL-2_Contact_Language_of_Communication", Order = 2)]
		public string RL2_Contact_Language_of_Communication
		{
			get
			{
				return this.rL2_Contact_Language_of_CommunicationField;
			}
			set
			{
				this.rL2_Contact_Language_of_CommunicationField = value;
				this.RaisePropertyChanged("RL2_Contact_Language_of_Communication");
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
