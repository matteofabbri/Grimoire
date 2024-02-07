using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Committee_Meeting_Vote_Record_Data_SubeditType : INotifyPropertyChanged
	{
		private Committee_Meeting_Vote_RecordObjectType agenda_Item_Vote_Record_ReferenceField;

		private Committee_Meeting_Vote_StatusObjectType vote_Status_ReferenceField;

		private decimal vote_CountField;

		private bool vote_CountFieldSpecified;

		private bool add_OnlyField;

		private bool add_OnlyFieldSpecified;

		private bool deleteField;

		private bool deleteFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Committee_Meeting_Vote_RecordObjectType Agenda_Item_Vote_Record_Reference
		{
			get
			{
				return this.agenda_Item_Vote_Record_ReferenceField;
			}
			set
			{
				this.agenda_Item_Vote_Record_ReferenceField = value;
				this.RaisePropertyChanged("Agenda_Item_Vote_Record_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Committee_Meeting_Vote_StatusObjectType Vote_Status_Reference
		{
			get
			{
				return this.vote_Status_ReferenceField;
			}
			set
			{
				this.vote_Status_ReferenceField = value;
				this.RaisePropertyChanged("Vote_Status_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Vote_Count
		{
			get
			{
				return this.vote_CountField;
			}
			set
			{
				this.vote_CountField = value;
				this.RaisePropertyChanged("Vote_Count");
			}
		}

		[XmlIgnore]
		public bool Vote_CountSpecified
		{
			get
			{
				return this.vote_CountFieldSpecified;
			}
			set
			{
				this.vote_CountFieldSpecified = value;
				this.RaisePropertyChanged("Vote_CountSpecified");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Add_Only
		{
			get
			{
				return this.add_OnlyField;
			}
			set
			{
				this.add_OnlyField = value;
				this.RaisePropertyChanged("Add_Only");
			}
		}

		[XmlIgnore]
		public bool Add_OnlySpecified
		{
			get
			{
				return this.add_OnlyFieldSpecified;
			}
			set
			{
				this.add_OnlyFieldSpecified = value;
				this.RaisePropertyChanged("Add_OnlySpecified");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Delete
		{
			get
			{
				return this.deleteField;
			}
			set
			{
				this.deleteField = value;
				this.RaisePropertyChanged("Delete");
			}
		}

		[XmlIgnore]
		public bool DeleteSpecified
		{
			get
			{
				return this.deleteFieldSpecified;
			}
			set
			{
				this.deleteFieldSpecified = value;
				this.RaisePropertyChanged("DeleteSpecified");
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
