using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Compensation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Update_Stock_Grant_RequestType : INotifyPropertyChanged
	{
		private Stock_GrantObjectType stock_Grant_ReferenceField;

		private Update_Stock_Grant_DataType stock_Grant_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Stock_GrantObjectType Stock_Grant_Reference
		{
			get
			{
				return this.stock_Grant_ReferenceField;
			}
			set
			{
				this.stock_Grant_ReferenceField = value;
				this.RaisePropertyChanged("Stock_Grant_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Update_Stock_Grant_DataType Stock_Grant_Data
		{
			get
			{
				return this.stock_Grant_DataField;
			}
			set
			{
				this.stock_Grant_DataField = value;
				this.RaisePropertyChanged("Stock_Grant_Data");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
				this.RaisePropertyChanged("version");
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
