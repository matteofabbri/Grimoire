using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Supplier_Group_DataType : INotifyPropertyChanged
	{
		private string supplier_Group_IDField;

		private string supplier_Group_NameField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Supplier_Group_ID
		{
			get
			{
				return this.supplier_Group_IDField;
			}
			set
			{
				this.supplier_Group_IDField = value;
				this.RaisePropertyChanged("Supplier_Group_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Supplier_Group_Name
		{
			get
			{
				return this.supplier_Group_NameField;
			}
			set
			{
				this.supplier_Group_NameField = value;
				this.RaisePropertyChanged("Supplier_Group_Name");
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
