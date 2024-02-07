using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.WorkdayExtensibility
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Custom_List_Request_CriteriaType : INotifyPropertyChanged
	{
		private string custom_List_AliasField;

		private string custom_List_Value_AliasField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Custom_List_Alias
		{
			get
			{
				return this.custom_List_AliasField;
			}
			set
			{
				this.custom_List_AliasField = value;
				this.RaisePropertyChanged("Custom_List_Alias");
			}
		}

		[XmlElement(Order = 1)]
		public string Custom_List_Value_Alias
		{
			get
			{
				return this.custom_List_Value_AliasField;
			}
			set
			{
				this.custom_List_Value_AliasField = value;
				this.RaisePropertyChanged("Custom_List_Value_Alias");
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
