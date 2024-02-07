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
	public class Create_Subordinate_Sub_Business_ProcessType : INotifyPropertyChanged
	{
		private Business_Sub_Process_ParametersType[] business_Sub_Process_ParametersField;

		private Create_Subordinate_Event_DataType[] create_Subordinate_Event_DataField;

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

		[XmlElement("Create_Subordinate_Event_Data", Order = 1)]
		public Create_Subordinate_Event_DataType[] Create_Subordinate_Event_Data
		{
			get
			{
				return this.create_Subordinate_Event_DataField;
			}
			set
			{
				this.create_Subordinate_Event_DataField = value;
				this.RaisePropertyChanged("Create_Subordinate_Event_Data");
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
