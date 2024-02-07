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
	public class Default_Values_for_Worktag_Request_CriteriaType : INotifyPropertyChanged
	{
		private Worktag_Type_Configuration_SetObjectType[] taggable_Type_ReferenceField;

		private bool only_Return_Items_with_Default_ValueField;

		private bool only_Return_Items_with_Default_ValueFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Taggable_Type_Reference", Order = 0)]
		public Worktag_Type_Configuration_SetObjectType[] Taggable_Type_Reference
		{
			get
			{
				return this.taggable_Type_ReferenceField;
			}
			set
			{
				this.taggable_Type_ReferenceField = value;
				this.RaisePropertyChanged("Taggable_Type_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public bool Only_Return_Items_with_Default_Value
		{
			get
			{
				return this.only_Return_Items_with_Default_ValueField;
			}
			set
			{
				this.only_Return_Items_with_Default_ValueField = value;
				this.RaisePropertyChanged("Only_Return_Items_with_Default_Value");
			}
		}

		[XmlIgnore]
		public bool Only_Return_Items_with_Default_ValueSpecified
		{
			get
			{
				return this.only_Return_Items_with_Default_ValueFieldSpecified;
			}
			set
			{
				this.only_Return_Items_with_Default_ValueFieldSpecified = value;
				this.RaisePropertyChanged("Only_Return_Items_with_Default_ValueSpecified");
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
