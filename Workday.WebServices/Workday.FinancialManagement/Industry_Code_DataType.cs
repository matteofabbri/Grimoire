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
	public class Industry_Code_DataType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType industry_Code_ReferenceField;

		private string industry_Code_TextField;

		private Industry_Code_TypeObjectType industry_Code_Type_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Industry_Code_Reference
		{
			get
			{
				return this.industry_Code_ReferenceField;
			}
			set
			{
				this.industry_Code_ReferenceField = value;
				this.RaisePropertyChanged("Industry_Code_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Industry_Code_Text
		{
			get
			{
				return this.industry_Code_TextField;
			}
			set
			{
				this.industry_Code_TextField = value;
				this.RaisePropertyChanged("Industry_Code_Text");
			}
		}

		[XmlElement(Order = 2)]
		public Industry_Code_TypeObjectType Industry_Code_Type_Reference
		{
			get
			{
				return this.industry_Code_Type_ReferenceField;
			}
			set
			{
				this.industry_Code_Type_ReferenceField = value;
				this.RaisePropertyChanged("Industry_Code_Type_Reference");
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
