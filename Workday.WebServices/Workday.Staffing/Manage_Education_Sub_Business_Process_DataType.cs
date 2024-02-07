using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Manage_Education_Sub_Business_Process_DataType : INotifyPropertyChanged
	{
		private Business_Sub_Process_ParametersType[] business_Sub_Process_ParametersField;

		private Manage_Education_Data_for_RoleType[] manage_Education_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Business_Sub_Process_Parameters", Order = 0)]
		public Business_Sub_Process_ParametersType[] Business_Sub_Process_Parameters
		{
			get
			{
				return this.business_Sub_Process_ParametersField;
			}
			set
			{
				this.business_Sub_Process_ParametersField = value;
				this.RaisePropertyChanged("Business_Sub_Process_Parameters");
			}
		}

		[XmlElement("Manage_Education_Data", Order = 1)]
		public Manage_Education_Data_for_RoleType[] Manage_Education_Data
		{
			get
			{
				return this.manage_Education_DataField;
			}
			set
			{
				this.manage_Education_DataField = value;
				this.RaisePropertyChanged("Manage_Education_Data");
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
