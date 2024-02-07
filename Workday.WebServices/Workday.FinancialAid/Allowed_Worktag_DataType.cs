using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.FinancialAid
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Allowed_Worktag_DataType : INotifyPropertyChanged
	{
		private Accounting_Worktag_and_Aggregation_DimensionObjectType allowed_Worktag_ReferenceField;

		private bool delete_Allowed_ValueField;

		private bool delete_Allowed_ValueFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Accounting_Worktag_and_Aggregation_DimensionObjectType Allowed_Worktag_Reference
		{
			get
			{
				return this.allowed_Worktag_ReferenceField;
			}
			set
			{
				this.allowed_Worktag_ReferenceField = value;
				this.RaisePropertyChanged("Allowed_Worktag_Reference");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Delete_Allowed_Value
		{
			get
			{
				return this.delete_Allowed_ValueField;
			}
			set
			{
				this.delete_Allowed_ValueField = value;
				this.RaisePropertyChanged("Delete_Allowed_Value");
			}
		}

		[XmlIgnore]
		public bool Delete_Allowed_ValueSpecified
		{
			get
			{
				return this.delete_Allowed_ValueFieldSpecified;
			}
			set
			{
				this.delete_Allowed_ValueFieldSpecified = value;
				this.RaisePropertyChanged("Delete_Allowed_ValueSpecified");
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
