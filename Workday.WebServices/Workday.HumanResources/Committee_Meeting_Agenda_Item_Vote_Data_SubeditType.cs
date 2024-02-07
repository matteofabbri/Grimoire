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
	public class Committee_Meeting_Agenda_Item_Vote_Data_SubeditType : INotifyPropertyChanged
	{
		private Committee_Meeting_Agenda_Item_VoteObjectType agenda_Item_Vote_ReferenceField;

		private bool passing_VoteField;

		private bool passing_VoteFieldSpecified;

		private Committee_Meeting_Vote_Record_Data_SubeditType[] committee_Meeting_Vote_Record_Data_SubeditField;

		private bool add_OnlyField;

		private bool add_OnlyFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Committee_Meeting_Agenda_Item_VoteObjectType Agenda_Item_Vote_Reference
		{
			get
			{
				return this.agenda_Item_Vote_ReferenceField;
			}
			set
			{
				this.agenda_Item_Vote_ReferenceField = value;
				this.RaisePropertyChanged("Agenda_Item_Vote_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public bool Passing_Vote
		{
			get
			{
				return this.passing_VoteField;
			}
			set
			{
				this.passing_VoteField = value;
				this.RaisePropertyChanged("Passing_Vote");
			}
		}

		[XmlIgnore]
		public bool Passing_VoteSpecified
		{
			get
			{
				return this.passing_VoteFieldSpecified;
			}
			set
			{
				this.passing_VoteFieldSpecified = value;
				this.RaisePropertyChanged("Passing_VoteSpecified");
			}
		}

		[XmlElement("Committee_Meeting_Vote_Record_Data_Subedit", Order = 2)]
		public Committee_Meeting_Vote_Record_Data_SubeditType[] Committee_Meeting_Vote_Record_Data_Subedit
		{
			get
			{
				return this.committee_Meeting_Vote_Record_Data_SubeditField;
			}
			set
			{
				this.committee_Meeting_Vote_Record_Data_SubeditField = value;
				this.RaisePropertyChanged("Committee_Meeting_Vote_Record_Data_Subedit");
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
