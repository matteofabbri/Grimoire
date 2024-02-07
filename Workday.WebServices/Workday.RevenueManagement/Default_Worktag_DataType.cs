using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Default_Worktag_DataType : INotifyPropertyChanged
	{
		private Accounting_Worktag_and_Aggregation_DimensionObjectType default_Worktag_ReferenceField;

		private bool delete_Default_ValueField;

		private bool delete_Default_ValueFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Accounting_Worktag_and_Aggregation_DimensionObjectType Default_Worktag_Reference
		{
			get
			{
				return this.default_Worktag_ReferenceField;
			}
			set
			{
				this.default_Worktag_ReferenceField = value;
				this.RaisePropertyChanged("Default_Worktag_Reference");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Delete_Default_Value
		{
			get
			{
				return this.delete_Default_ValueField;
			}
			set
			{
				this.delete_Default_ValueField = value;
				this.RaisePropertyChanged("Delete_Default_Value");
			}
		}

		[XmlIgnore]
		public bool Delete_Default_ValueSpecified
		{
			get
			{
				return this.delete_Default_ValueFieldSpecified;
			}
			set
			{
				this.delete_Default_ValueFieldSpecified = value;
				this.RaisePropertyChanged("Delete_Default_ValueSpecified");
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
