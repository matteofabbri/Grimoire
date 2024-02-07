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
	public class Custom_List_ValueType : INotifyPropertyChanged
	{
		private string orderField;

		private string list_Value_NameField;

		private string web_Service_AliasField;

		private bool deprecatedField;

		private bool deprecatedFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Order
		{
			get
			{
				return this.orderField;
			}
			set
			{
				this.orderField = value;
				this.RaisePropertyChanged("Order");
			}
		}

		[XmlElement(Order = 1)]
		public string List_Value_Name
		{
			get
			{
				return this.list_Value_NameField;
			}
			set
			{
				this.list_Value_NameField = value;
				this.RaisePropertyChanged("List_Value_Name");
			}
		}

		[XmlElement(Order = 2)]
		public string Web_Service_Alias
		{
			get
			{
				return this.web_Service_AliasField;
			}
			set
			{
				this.web_Service_AliasField = value;
				this.RaisePropertyChanged("Web_Service_Alias");
			}
		}

		[XmlElement(Order = 3)]
		public bool Deprecated
		{
			get
			{
				return this.deprecatedField;
			}
			set
			{
				this.deprecatedField = value;
				this.RaisePropertyChanged("Deprecated");
			}
		}

		[XmlIgnore]
		public bool DeprecatedSpecified
		{
			get
			{
				return this.deprecatedFieldSpecified;
			}
			set
			{
				this.deprecatedFieldSpecified = value;
				this.RaisePropertyChanged("DeprecatedSpecified");
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
